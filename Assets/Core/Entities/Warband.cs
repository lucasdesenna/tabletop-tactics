using Assets.Core.Interfaces;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public interface IWarband : IWithInventory
    {
        int? Funds { get; set; }

        List<ISoldier> Soldiers { get; }

        IWizard Wizard { get; }

        IWizard Apprentice { get; }

        public void AddSoldier(ISoldier soldier)
        {
            Soldiers.Add(soldier);
        }

        public void RemoveSoldier(ISoldier soldier)
        {
            Soldiers.Remove(soldier);
        }
    }

    public class Warband : IWarband
    {
        private int? _funds = 0;
        public int? Funds { get => _funds; set => _funds = value; }

        private readonly int? _capacity = null;
        public int? ItemCapacity { get => _capacity; }

        private readonly List<IItem> _items = new();
        public  List<IItem> Items { get => _items; }

        private IWizard _wizard;
        public IWizard Wizard { get => _wizard; private set => _wizard = value; }

        private IWizard _apprentice;
        public IWizard Apprentice { get => _apprentice; private set => _apprentice = value; }


        private readonly List<ISoldier> _soldiers = new();
        public List<ISoldier> Soldiers => _soldiers;

        public Warband() {}

        public Warband(int funds, List<IItem> items, Wizard wizard, Apprentice apprentice, List<ISoldier> soldiers)
        {
            _funds = funds;
            _items = items;
            _wizard = wizard;
            _apprentice = apprentice;
            _soldiers = soldiers;
        }

        public void AddSoldier(Soldier soldier)
        {
            Soldiers.Add(soldier);
        }

        public void RemoveSoldier(Soldier soldier)
        {
            Soldiers.Remove(soldier);
        }

        public void SetApprentice(Apprentice apprentice)
        {
            _apprentice = apprentice;
        }

        public void SetWizard(Wizard wizard)
        {
            _wizard = wizard;
        }
    }
}