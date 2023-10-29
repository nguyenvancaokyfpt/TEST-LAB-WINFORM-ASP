using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;

namespace TestLabManagerAppWPF.ViewModel
{
    class SubmitPaperViewModel : ViewModelBase
    {
        private ObservableCollection<TlPaperObj> _papers;
        private ObservableCollection<TlSubmitpaperObj> _submitpapers;
        private TlPaperObj _selectedPaper;
        private string _searchText = "";

        public ObservableCollection<TlPaperObj> Papers
        {
            get
            {
                return _papers;
            }
            set
            {
                _papers = value;
                OnPropertyChanged(nameof(Papers));
            }
        }

        public ObservableCollection<TlSubmitpaperObj> Submitpapers
        {
            get
            {
                return _submitpapers;
            }
            set
            {
                _submitpapers = value;
                OnPropertyChanged(nameof(Submitpapers));
            }
        }

        public TlPaperObj SelectedPaper
        {
            get
            {
                return _selectedPaper;
            }
            set
            {
                _selectedPaper = value;
                LoadSubmitPapers(value.Id);
                OnPropertyChanged(nameof(SelectedPaper));
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        // Load papers
        public void LoadPapers()
        {
            var paperRepo = MyService.serviceProvider.GetService<IPaperRepository>();
            var papersEf = paperRepo.GetPapers();
            Papers = new ObservableCollection<TlPaperObj>(MyMapper.mapper.Map<List<TlPaperObj>>(papersEf));
        }
        // Load submit papers
        public void LoadSubmitPapers(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            var submitpaperRepo = MyService.serviceProvider.GetService<IPaperRepository>();
            var submitpapersEf = new ObservableCollection<TlSubmitpaper>(submitpaperRepo.GetSubmitPapers(0, 9999, pid, SearchText));
            Submitpapers = new ObservableCollection<TlSubmitpaperObj>(MyMapper.mapper.Map<List<TlSubmitpaperObj>>(submitpapersEf));
        }

        // Get Selected SubmitPapers
        public List<TlSubmitpaperObj> GetSelectedSubmitPapers()
        {
            List<TlSubmitpaperObj> selectedSubmitPapers = new List<TlSubmitpaperObj>();
            foreach (var submitpaper in Submitpapers)
            {
                if (submitpaper.IsSelected)
                {
                    selectedSubmitPapers.Add(submitpaper);
                }
            }
            return selectedSubmitPapers;
        }

        // Command
        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public SubmitPaperViewModel()
        {
            LoadPapers();
            LoadSubmitPapers(0);

            SearchCommand = new ViewModelCommand(ExuteSearchCommand, null);
            AddCommand = new ViewModelCommand(ExuteAddCommand, null);
            EditCommand = new ViewModelCommand(ExuteEditCommand, null);
            DeleteCommand = new ViewModelCommand(ExuteDeleteCommand, null);
        }

        private void ExuteDeleteCommand(object obj)
        {
            // Get selected submitpaper
            var selectedSubmitPapers = GetSelectedSubmitPapers();
            if (selectedSubmitPapers.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select submitpaper(s) to delete!", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }
            var submitpaperRepo = MyService.serviceProvider.GetService<IPaperRepository>();
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure to delete all selected submitpaper?", "Delete submitpaper", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Delete submitpaper
                foreach (var submitpaper in selectedSubmitPapers)
                {
                    submitpaperRepo.DeleteSubmitPaper(submitpaper.Id);
                }
                System.Windows.MessageBox.Show("Delete submitpaper successfully!");
                LoadSubmitPapers(SelectedPaper.Id);
            }
        }

        private void ExuteEditCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExuteAddCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExuteSearchCommand(object obj)
        {
            if (SelectedPaper == null)
            {
                return;
            }
            LoadSubmitPapers(SelectedPaper.Id);
        }
    }
}
