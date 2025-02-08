﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Helper;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;

namespace MVVMFirma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {

                new CommandViewModel(
                    "Klienci",
                    new BaseCommand(() => this.ShowAllKlienci())),

                new CommandViewModel(
                    "Nowy klient",
                    new BaseCommand(() => this.CreateKlient())),

                new CommandViewModel(
                    "Użytkownicy",
                    new BaseCommand(() => this.ShowAllUzytkownicy())),

                new CommandViewModel(
                    "Nowy użytkownik",
                    new BaseCommand(() => this.CreateUzytkownik())),

                new CommandViewModel(
                    "Faktury",
                    new BaseCommand(() => this.ShowAllFaktury())),

                new CommandViewModel(
                    "Nowa faktura",
                    new BaseCommand(() => this.CreateFaktura())),

                new CommandViewModel(
                    "Produkty i usługi",
                    new BaseCommand(() => this.ShowAllProduktyUslugi())),

                new CommandViewModel(
                    "Nowy produkt",
                    new BaseCommand(() => this.CreateProduktUsluga())),

                new CommandViewModel(
                    "Rodzaje Interakcji",
                    new BaseCommand(() => this.ShowAllTypyInterakcji())),

                new CommandViewModel(
                    "Projekty",
                    new BaseCommand(() => this.ShowAllProjekty())),

                 new CommandViewModel(
                    "Statusy",
                    new BaseCommand(() => this.ShowAllStatusy())),

                  new CommandViewModel(
                    "Relacje",
                    new BaseCommand(() => this.ShowAllRelacjeMiedzyKlientami())),

                  new CommandViewModel(
                    "Rodzaje płatności",
                    new BaseCommand(() => this.ShowAllRodzajePlatnosci())),

                  new CommandViewModel(
                    "Status Faktury",
                    new BaseCommand(() => this.ShowAllStatusFaktury())),

                  new CommandViewModel(
                    "Szkolenia",
                    new BaseCommand(() => this.ShowAllSzkolenia())),
            };
        }

        #endregion

        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }

        #endregion // Workspaces

        #region Private Helpers
        private void CreateKlient()
        {
            NowyKlientViewModel workspace = new NowyKlientViewModel();
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }

        private void CreateUzytkownik()
        {
            NowyUzytkownikViewModel workspace = new NowyUzytkownikViewModel();
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }

        private void CreateFaktura()
        {
           NowaFakturaViewModel workspace = new NowaFakturaViewModel();
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        } 
        
        private void CreateProduktUsluga()
        {
            NowyProduktUslugaViewModel workspace = new NowyProduktUslugaViewModel();
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }
        
        private void ShowAllKlienci()
        {
            if (!(this.Workspaces.FirstOrDefault(vm => vm is KlienciViewModel) is KlienciViewModel workspace))
            {
                workspace = new KlienciViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);

        }
        private void ShowAllUzytkownicy()
        {
            UzytkownicyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is UzytkownicyViewModel)
                as UzytkownicyViewModel;
            if (workspace == null)
            {
                workspace = new UzytkownicyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }
        private void ShowAllFaktury()
        {
            FakturyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is FakturyViewModel)
                as FakturyViewModel;
            if (workspace == null)
            {
                workspace = new FakturyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllProduktyUslugi()
        {
            ProduktyUslugiViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is ProduktyUslugiViewModel)
                as ProduktyUslugiViewModel;
            if (workspace == null)
            {
                workspace = new ProduktyUslugiViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);

        }

        private void ShowAllStatusy()
        {
                StatusyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is StatusyViewModel)
                as StatusyViewModel;
            if (workspace == null)
            {
                workspace = new StatusyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllTypyInterakcji()
        {
            TypyInterakcjiViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is TypyInterakcjiViewModel)
                as TypyInterakcjiViewModel;
            if (workspace == null)
            {
                workspace = new TypyInterakcjiViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllProjekty()
        {
            ProjektyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is ProjektyViewModel)
                as ProjektyViewModel;
            if (workspace == null)
            {
                workspace = new ProjektyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllRelacjeMiedzyKlientami()
        {
            RelacjeMiedzyKlientamiViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is RelacjeMiedzyKlientamiViewModel)
                as RelacjeMiedzyKlientamiViewModel;
            if (workspace == null)
            {
                workspace = new RelacjeMiedzyKlientamiViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllRodzajePlatnosci()
        {
            RodzajePlatnosciViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is RodzajePlatnosciViewModel)
                as RodzajePlatnosciViewModel;
            if (workspace == null)
            {
                workspace = new RodzajePlatnosciViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllStatusFaktury()
        {
            StatusFakturyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is StatusFakturyViewModel)
                as StatusFakturyViewModel;
            if (workspace == null)
            {
                workspace = new StatusFakturyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllSzkolenia()
        {
            SzkoleniaViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is SzkoleniaViewModel)
                as SzkoleniaViewModel;
            if (workspace == null)
            {
                workspace = new SzkoleniaViewModel();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            collectionView?.MoveCurrentTo(workspace);
        }
        #endregion
    }
}
