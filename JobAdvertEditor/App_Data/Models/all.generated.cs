using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "dcc81102994c4a8e")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.3")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Metadata</summary>
	[PublishedContentModel("metadata")]
	public partial class Metadata : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "metadata";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Metadata(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Metadata, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}
	}

	/// <summary>BasePage</summary>
	[PublishedContentModel("basePage")]
	public partial class BasePage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : BasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>SectionPage</summary>
	[PublishedContentModel("sectionPage")]
	public partial class SectionPage : BasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sectionPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SectionPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SectionPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>ContentPage</summary>
	[PublishedContentModel("contentPage")]
	public partial class ContentPage : BasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contentPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContentPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>AdvertisingOrganisation</summary>
	[PublishedContentModel("advertisingOrganisation")]
	public partial class AdvertisingOrganisation : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "advertisingOrganisation";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AdvertisingOrganisation(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AdvertisingOrganisation, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Us: Add a brief description of the organisation or practice.
		///</summary>
		[ImplementPropertyType("aboutUs")]
		public IHtmlString AboutUs
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutUs"); }
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return this.GetPropertyValue<string>("address"); }
		}

		///<summary>
		/// eMail: Add the default email you want to be contacted by here. You can use a different one for informal contacts for each advert if you wish.
		///</summary>
		[ImplementPropertyType("eMail")]
		public string EMail
		{
			get { return this.GetPropertyValue<string>("eMail"); }
		}

		///<summary>
		/// Organisation Name: Enter your organisation or practice name
		///</summary>
		[ImplementPropertyType("organisationName")]
		public string OrganisationName
		{
			get { return this.GetPropertyValue<string>("organisationName"); }
		}

		///<summary>
		/// Our Values: If you have a specific vision or values statement, you can enter it here.
		///</summary>
		[ImplementPropertyType("ourValues")]
		public IHtmlString OurValues
		{
			get { return this.GetPropertyValue<IHtmlString>("ourValues"); }
		}

		///<summary>
		/// Postcode: Your postcode. If there's a postcode in this box, it will be used as the default location for jobs but you can still enter a different postcode for each job if you want to when you create a new advert.
		///</summary>
		[ImplementPropertyType("postcode")]
		public string Postcode
		{
			get { return this.GetPropertyValue<string>("postcode"); }
		}

		///<summary>
		/// Telephone Number: Enter your main telephone number. You can use different numbers for information contacts on a job specific basis too but this number will be used as the default number for all telephone contacts though if you don't.
		///</summary>
		[ImplementPropertyType("telephoneNumber")]
		public string TelephoneNumber
		{
			get { return this.GetPropertyValue<string>("telephoneNumber"); }
		}

		///<summary>
		/// Website address: Put your website address in here.
		///</summary>
		[ImplementPropertyType("websiteAddress")]
		public Umbraco.Web.Models.RelatedLinks WebsiteAddress
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("websiteAddress"); }
		}

		///<summary>
		/// What3Words Location: The W3W location is another way to locate your organisation. (You can find out more at https://what3words.com/ or just leave blank if you wish and we'll use the postcode.)
		///</summary>
		[ImplementPropertyType("what3WordsLocation")]
		public string What3WordsLocation
		{
			get { return this.GetPropertyValue<string>("what3WordsLocation"); }
		}

		///<summary>
		/// Working with us: Describe your organisation and why it's a great place to work.
		///</summary>
		[ImplementPropertyType("workingWithUs")]
		public IHtmlString WorkingWithUs
		{
			get { return this.GetPropertyValue<IHtmlString>("workingWithUs"); }
		}
	}

	/// <summary>JobAd</summary>
	[PublishedContentModel("jobAd")]
	public partial class JobAd : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "jobAd";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public JobAd(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<JobAd, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Closing Date
		///</summary>
		[ImplementPropertyType("closingDate")]
		public DateTime ClosingDate
		{
			get { return this.GetPropertyValue<DateTime>("closingDate"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Image1
		///</summary>
		[ImplementPropertyType("image1")]
		public IPublishedContent Image1
		{
			get { return this.GetPropertyValue<IPublishedContent>("image1"); }
		}

		///<summary>
		/// Job Family
		///</summary>
		[ImplementPropertyType("jobFamily")]
		public string JobFamily
		{
			get { return this.GetPropertyValue<string>("jobFamily"); }
		}

		///<summary>
		/// Job Reference Number
		///</summary>
		[ImplementPropertyType("jobRef")]
		public string JobRef
		{
			get { return this.GetPropertyValue<string>("jobRef"); }
		}

		///<summary>
		/// Locum Post: Please check the box if this is a locum post
		///</summary>
		[ImplementPropertyType("locumPost")]
		public bool LocumPost
		{
			get { return this.GetPropertyValue<bool>("locumPost"); }
		}

		///<summary>
		/// More Information: You can upload a file with more information about the job or the practice if you wish. Pdfs are preferred but Word documents or Powerpoint are ok too.
		///</summary>
		[ImplementPropertyType("moreInformation")]
		public string MoreInformation
		{
			get { return this.GetPropertyValue<string>("moreInformation"); }
		}

		///<summary>
		/// Postcode: Add a postcode to allow the location of the vacancy to be added to a map.
		///</summary>
		[ImplementPropertyType("postcode")]
		public string Postcode
		{
			get { return this.GetPropertyValue<string>("postcode"); }
		}

		///<summary>
		/// Salary
		///</summary>
		[ImplementPropertyType("salary")]
		public string Salary
		{
			get { return this.GetPropertyValue<string>("salary"); }
		}

		///<summary>
		/// Short Description: Add a short description of the job suitable for appearing in a list of jobs. Its optional - if you don't use it the first few words of the main description will be used instead.
		///</summary>
		[ImplementPropertyType("shortDescription")]
		public string ShortDescription
		{
			get { return this.GetPropertyValue<string>("shortDescription"); }
		}

		///<summary>
		/// Title: Enter a job title. Use terms like GP, General practitioner, GP Partner (add other key terms like locum or salaried if applicable)
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Vacancy Type: You can check the boxes to give us some more information on the vacancy. It's optional but if you supply it it will help the vacancy to be found more accurately in searches.
		///</summary>
		[ImplementPropertyType("vacancyType")]
		public int VacancyType
		{
			get { return this.GetPropertyValue<int>("vacancyType"); }
		}

		///<summary>
		/// Who we're looking for: You can give a short description of the type of person you're looking for here if you want.
		///</summary>
		[ImplementPropertyType("whoWereLookingFor")]
		public IHtmlString WhoWereLookingFor
		{
			get { return this.GetPropertyValue<IHtmlString>("whoWereLookingFor"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
