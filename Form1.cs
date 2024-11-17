namespace cw03
{
    
    public partial class Form1 : Form
    {
    void AddLast(int liczba)
        {
            var temp = new Node(liczba);
            temp prec = this tail;
            this tail.next = temp;
            this tail = temp;
            this.count++;
            return temp;

        }
        // DO DOMU(wczesniejsze)!!!!    AddFirst()  RemoveLast()   RemoveFirst()  Get(int index)   ToString()

        //DO DOMU OEBCNE CWICZENIE   zdjêcie, remove()


        public Form1()
        {
            InitializeComponent();
        }
    }
}