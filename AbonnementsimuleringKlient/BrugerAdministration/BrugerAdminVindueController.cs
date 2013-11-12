using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class BrugerAdminVindueController : IObservable<IBrugerDAO>
    {
        private IBrugerAdminVindue _brugerAdminVindue;
        private List<IObserver<IBrugerDAO>> _observers;
        private IBrugerDAO _aktuelBruger;
        private IndstillingerVindueController _indstillingerVindueController;
        public List<IBrugerDAO> medarbejderListe { get; set; }

        public List<IBrugerDAO> getTempListTEST()
        {
            List<IBrugerDAO> tempList = new List<IBrugerDAO>();

            IBrugerDAO first = new BrugerDAO("Mads", "Slotsbo", 1, true, "hallo");
            IBrugerDAO second = new BrugerDAO("Bjørn", "Andersen", 2, false, "hallo");
            IBrugerDAO third = new BrugerDAO("Lasse", "Redlaz", 3, false, "hallo");
            IBrugerDAO fourth = new BrugerDAO("Jesper", "Baltzersen", null, false, "hallo");
            tempList.Add(first);
            tempList.Add(second);
            tempList.Add(third);
            tempList.Add(fourth);
            return tempList;
        }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue)
        {
            this._brugerAdminVindue = brugerAdminVindue;
            brugerAdminVindue.SetBrugerAdminVindueController(this);
            _observers = new List<IObserver<IBrugerDAO>>();
        }

        public void SetControllers(IndstillingerVindueController indstillingerVindueController)
        {
            this._indstillingerVindueController = indstillingerVindueController;
        }

        public void OpenIndstilleringVindue()
        {
            _indstillingerVindueController.OpenVindue();
        }

        public void OpenVindue(IBrugerDAO bruger)
        {
            this._brugerAdminVindue.OpenVindue();
            this._aktuelBruger = bruger;
        }

        public void CloseVindue()
        {
            _brugerAdminVindue.CloseVindue();
        }

        public IDisposable Subscribe(IObserver<IBrugerDAO> observer)
        {
            if (!_observers.Contains(observer))
            {
                if (medarbejderListe != null)
                {
                    foreach (var bruger in medarbejderListe)
                    {
                        observer.OnNext(bruger);
                    }

                }
            }
            return new Unsubscriber<IBrugerDAO>(_observers, observer);
        }

        internal class Unsubscriber<IBrugerDAO> : IDisposable
        {
            private List<IObserver<IBrugerDAO>> _observers;
            private IObserver<IBrugerDAO> _observer;

            internal Unsubscriber(List<IObserver<IBrugerDAO>> observers, IObserver<IBrugerDAO> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

      
    }
}