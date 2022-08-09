namespace BlazorGiris.Data
{
    public class Expense
    {
        public int id {  get; set; }
        public string? title { get; set; }
        public double amount { get; set; }
        public string ? description { get; set; }

        public List<Expense> _expenseList= new List<Expense>();


        public Expense(string Title,double _amount,string _description)
        {
            this.title = Title;
            this.amount = _amount;
            this.description = _description;
        }

        public void FillList()
        {
            for(int i = 0; i < 6; i++)
            {
                Expense _first = new Expense("Test"+i, 15.49+i, "Blazor Model Denemesi "+i);
                _first.id = i;
                _expenseList.Add(_first);
            }
        }
        public Expense GetItemById(int _id)
        {
            foreach(var it in _expenseList)
            {
                if(it.id == _id)
                {
                    return it;
                }
                
            }
            return null;
        }
        public List<Expense> GetListOfExpense()
        {
            return _expenseList;
        }
        public Expense() { }


    }
}
