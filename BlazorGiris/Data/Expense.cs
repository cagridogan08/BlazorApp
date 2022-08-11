namespace BlazorGiris.Data
{
    public class Expense
    {
        public int id {  get; set; }
        public string? Title { get; set; }
        public double amount { get; set; }
        public string ? description { get; set; }

        public List<Expense> _expenseList= new List<Expense>();


        public Expense(string _title,double _amount,string _description)
        {
            this.Title = _title;
            this.amount = _amount;
            this.description = _description;
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
