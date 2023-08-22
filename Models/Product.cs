using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST10084788_PROG7311_POE.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }


        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "The Product Name Is A Mandatory Field")]
        [MaxLength(50, ErrorMessage = "The Product Name Cannot Have More Than 50 Characters")]
        [MinLength(3, ErrorMessage = "The Product Name Must Have At Least 3 Characters")]
        public string ProductName { get; set; }

        
        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "The Product Description Is A Mandatory Field")]
        [MaxLength(80, ErrorMessage = "The Product Description Cannot Have More Than 80 Characters")]
        [MinLength(5, ErrorMessage = "The Product Description Must Have At Least 5 Characters")]
        public string ProductDesc { get; set; }

        [Display(Name = "Product Category")]
        [Required(ErrorMessage = "The Product Category Is A Mandatory Field")]
        
        public string ProductCategory { get; set; }


        [Display(Name = "Product Quantity")]
        [Required(ErrorMessage = "The Product Quantity Is A Mandatory Field")]
        public int Quantity { get; set; }


        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "The Product Price Is A Mandatory Field")]
        [Column(TypeName = "decimal(10, 2)")] // Adjust the precision and scale as needed
        public decimal Price { get; set; }
      
       

        [Display(Name = "Date Added")]
        [Required(ErrorMessage = "The Date Added Is A Mandatory Field")]
        public DateTime DateAdded { get; set; }


        
        public string FarmerID { get; set; } // the Id of the Farmer that the product belongs to 

        [Display(Name = "Image URL")]
        [Required(ErrorMessage = "The image URL Is A Mandatory Field")]
        public string ProductImage { get; set; } // holds URL of image
    }
}
