using BookingManagement.ModelViews;
using BookingManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement
{
    static class BookingManagement
    {
        public static FacilityMV FacilityMV { get; set; } = new FacilityMV();
        public static BookingDetailMV BookingDetailMV { get; set; } = new BookingDetailMV();
        public static OptionMV OptionMV { get; set; } = new OptionMV();

        public static ClientForm Form { get; set; } 
    }
}
