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
    
    public partial class Market_Main
    {
        public int Market_Main_id { get; set; }
        public Nullable<int> Departments_id { get; set; }
        public Nullable<int> Goods_id { get; set; }
        public Nullable<int> Sell_id { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Good Good { get; set; }
        public virtual Sell Sell { get; set; }
    }
}