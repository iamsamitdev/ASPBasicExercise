//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace ASPMVCProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int CustomerId { get; set; }

		[Required(ErrorMessage ="��͹���͡�͹")]
		[MinLength(5)]
		//[RegularExpression("^[A-Z�-�]*$")]
		[RegularExpression("[�-�]")]
		[Display(Name ="����")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "��͹���ʡ�š�͹")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "��͹���ء�͹")]
		public Nullable<int> Age { get; set; }
		[Required(ErrorMessage = "��͹���͡�͹")]
		public string Gender { get; set; }
		[Required(ErrorMessage = "��͹��������͹")]
		public string Address { get; set; }
		[Required(ErrorMessage = "��͹ʶҹС�͹")]
		public Nullable<int> status { get; set; }
    }
}
