//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market_Pl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            this.Market_Main = new HashSet<Market_Main>();
        }
    
        public int Goods_id { get; set; }
        public string Goods_Article { get; set; }
        public string Goods_Name { get; set; }
        public string Goods_Unit { get; set; }
        public string Goods_Sum { get; set; }

        public string Article
        {
            get
            {
                return "Артикул: " + this.Goods_Article;
            }
        }
        public string Name
        {
            get
            {
                return "Наименование: " + this.Goods_Name;
            }
        }
        public string Unit
        {
            get
            {
                return "Ед. измер.: " + this.Goods_Unit;
            }
        }
        public string Sum
        {
            get
            {
                return "Цена: " + this.Goods_Sum + " .руб";
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Market_Main> Market_Main { get; set; }
    }
}
