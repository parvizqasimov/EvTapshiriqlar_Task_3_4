namespace EvTapshiriqlar_Task_3_4.git
{
    internal class Book : Object
    {

        /* Kitabın adı(Name) 
            Müəllifin adı(AuthorName)
            Nəşr ili(PublishedDate)
            Səhifə sayı(PageCount)    (10-dan az reqem daxil etmek olmasin*/

        internal string Name;
        internal string AuthorName;
        internal string Publishdate;
        internal int PageCount;

        public override string ToString()
        {
            return $"{AuthorName} {Name} {Publishdate} {PageCount}";
        }
    }

}
