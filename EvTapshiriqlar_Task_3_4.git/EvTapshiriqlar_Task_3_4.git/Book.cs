namespace EvTapshiriqlar_Task_3_4.git
{
    public class Book : Object
    {

        /* Kitabın adı(Name) 
            Müəllifin adı(AuthorName)
            Nəşr ili(PublishedDate)
            Səhifə sayı(PageCount)    (10-dan az reqem daxil etmek olmasin*/

        public string Name;
        public string AuthorName;
        public string Publishdate;
        public int PageCount;

        public override string ToString()
        {
            return $"{AuthorName} {Name} {Publishdate} {PageCount}";
        }
    }

}
