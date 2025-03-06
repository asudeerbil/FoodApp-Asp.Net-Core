using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProje.Dto
{
    public class ListViewModel
    {
        public SelectList Categories { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}
