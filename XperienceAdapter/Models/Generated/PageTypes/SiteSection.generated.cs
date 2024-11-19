//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MedioClinic;

[assembly: RegisterDocumentType(SiteSection.CLASS_NAME, typeof(SiteSection))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type SiteSection.
	/// </summary>
	public partial class SiteSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.SiteSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with SiteSection fields.
		/// </summary>
		private readonly SiteSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// SiteSectionID.
		/// </summary>
		[DatabaseIDField]
		public int SiteSectionID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("SiteSectionID"), 0);
			}
			set
			{
				SetValue("SiteSectionID", value);
			}
		}


		/// <summary>
		/// SiteSectionName.
		/// </summary>
		[DatabaseField]
		public string SiteSectionName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SiteSectionName"), @"");
			}
			set
			{
				SetValue("SiteSectionName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with SiteSection fields.
		/// </summary>
		[RegisterProperty]
		public SiteSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with SiteSection fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class SiteSectionFields : AbstractHierarchicalObject<SiteSectionFields>
		{
			/// <summary>
			/// The content item of type SiteSection that is a target of the extended API.
			/// </summary>
			private readonly SiteSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="SiteSectionFields" /> class with the specified content item of type SiteSection.
			/// </summary>
			/// <param name="instance">The content item of type SiteSection that is a target of the extended API.</param>
			public SiteSectionFields(SiteSection instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// SiteSectionID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.SiteSectionID;
				}
				set
				{
					mInstance.SiteSectionID = value;
				}
			}


			/// <summary>
			/// SiteSectionName.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.SiteSectionName;
				}
				set
				{
					mInstance.SiteSectionName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="SiteSection" /> class.
		/// </summary>
		public SiteSection() : base(CLASS_NAME)
		{
			mFields = new SiteSectionFields(this);
		}

		#endregion
	}
}