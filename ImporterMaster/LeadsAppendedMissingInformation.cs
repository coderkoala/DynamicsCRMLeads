// Detailed Property Information

#region Valid_Address
var Valid_Address = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Valid_Address",
	LogicalName = "lead_Valid_Address",

	DisplayName = new Label("Valid Address", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Valid Address", _languageCode),
	MaxLength = 320,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Valid_Address);
#endregion Valid_Address

#region Lead_Valid_Phone
// Create a memo attribute
var Lead_Valid_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Valid_Phone",
	LogicalName = "lead_Valid_Phone",
	DisplayName = new Label("Lead Valid Phone", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired),
	Description = new Label("Lead Valid Phone", _languageCode),
	// Set extended properties
	Format = StringFormat.Phone,
	ImeMode = ImeMode.Disabled,
	MaxLength = 25,
	IsValidForForm = true,
	IsValidForGrid = true,
};
addedAttributes.Add(Lead_Valid_Phone);
#endregion Lead_Valid_Phone

#region Valid_Email
var Valid_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Valid_Email",
	LogicalName = "lead_Valid_Email",

	DisplayName = new Label("Valid Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Valid Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,
	Format = StringFormat.Email,
};
addedAttributes.Add(Valid_Email);
#endregion Valid_Email

#region Valid_Name
var Valid_Name = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Valid_Name",
	LogicalName = "lead_Valid_Name",

	DisplayName = new Label("Valid Name", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Valid Name", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Valid_Name);
#endregion Valid_Name

#region Name_to_Phone
var Name_to_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Name_to_Phone",
	LogicalName = "lead_Name_to_Phone",

	DisplayName = new Label("Name to Phone", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Name to Phone", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Name_to_Phone);
#endregion Name_to_Phone

#region Name_to_Email
var Name_to_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Name_to_Email",
	LogicalName = "lead_Name_to_Email",

	DisplayName = new Label("Name to Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Name to Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Name_to_Email);
#endregion Name_to_Email

#region Name_To_Address
var Name_To_Address = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Name_To_Address",
	LogicalName = "lead_Name_To_Address",

	DisplayName = new Label("Name to Address", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Name to Address", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Name_To_Address);
#endregion Name_To_Address

#region Address_To_Phone
var Address_To_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Address_To_Phone",
	LogicalName = "lead_Address_To_Phone",

	DisplayName = new Label("Address to Phone", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Address to Phone", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Address_To_Phone);
#endregion Address_To_Phone

#region Address_To_Email
var Address_To_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Address_To_Email",
	LogicalName = "lead_Address_To_Email",

	DisplayName = new Label("Address to Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Address to Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Address_To_Email);
#endregion Address_To_Email

#region Phone_To_Email
var Phone_To_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Phone_To_Email",
	LogicalName = "lead_Phone_To_Email",

	DisplayName = new Label("Phone to Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Phone to Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Phone_To_Email);
#endregion Phone_To_Email

#region Name_of_Municipality
var Name_of_Municipality = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Name_of_Municipality",
	LogicalName = "lead_Name_of_Municipality",

	DisplayName = new Label("Name of Municipality", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Name of Municipality", _languageCode),
	// Set extended properties
	Format = StringFormat.Phone,
	ImeMode = ImeMode.Disabled,
	MaxLength = 25,
	IsValidForForm = true,
	IsValidForGrid = true,
};
addedAttributes.Add(Name_of_Municipality);
#endregion Name_of_Municipality

#region Subdivision
var Subdivision = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Subdivision",
	LogicalName = "lead_Subdivision",

	DisplayName = new Label("Subdivision", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Subdivision", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Subdivision);
#endregion Subdivision

#region Property_Latitude
var Property_Latitude = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_Latitude",
	LogicalName = "lead_Property_Latitude",

	DisplayName = new Label("Property Latitude", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property Latitude", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Property_Latitude);
#endregion Property_Latitude

#region Property_Longitude
var Property_Longitude = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_Longitude",
	LogicalName = "lead_Property_Longitude",

	DisplayName = new Label("Property Longitude", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property Longitude", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Property_Longitude);
#endregion Property_Longitude

#region Land_Use_Code
var Land_Use_Code = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Land_Use_Code",
	LogicalName = "lead_Land_Use_Code",

	DisplayName = new Label("Land Use Code", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Land Use Code", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Land_Use_Code);
#endregion Land_Use_Code

#region APN
var APN = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_APN",
	LogicalName = "lead_APN",

	DisplayName = new Label("APN", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("APN", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(APN);
#endregion APN

#region Business_Owner_Indicator
var Business_Owner_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Business_Owner_Indicator",
	LogicalName = "lead_Business_Owner_Indicator",

	DisplayName = new Label("Business Owner Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Business Owner Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Business_Owner_Indicator);
#endregion Business_Owner_Indicator

#region Property_Type_Indicator
var Property_Type_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_Type_Indicator",
	LogicalName = "lead_Property_Type_Indicator",

	DisplayName = new Label("Property Type Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property Type Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Property_Type_Indicator);
#endregion Property_Type_Indicator

#region Mobile_Home
var Mobile_Home = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mobile_Home",
	LogicalName = "lead_Mobile_Home",

	DisplayName = new Label("Mobile Home", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mobile Home", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mobile_Home);
#endregion Mobile_Home

#region Number_of_Buildings
var Number_of_Buildings = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Buildings",
	LogicalName = "lead_Number_of_Buildings",

	DisplayName = new Label("Number of Buildings", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Buildings", _languageCode),
	MaxLength = 5,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Buildings);
#endregion Number_of_Buildings

#region Style_Indicator
var Style_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Style_Indicator",
	LogicalName = "lead_Style_Indicator",

	DisplayName = new Label("Style Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Style Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Style_Indicator);
#endregion Style_Indicator

#region Number_of_Stories
var Number_of_Stories = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Stories",
	LogicalName = "lead_Number_of_Stories",

	DisplayName = new Label("Number of stories", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of stories", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Stories);
#endregion Number_of_Stories

#region Number_of_Stories_in_Building
var Number_of_Stories_in_Building = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Stories_in_Building",
	LogicalName = "lead_Number_of_Stories_in_Building",

	DisplayName = new Label("Number of Stories in Building", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Stories in Building", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Stories_in_Building);
#endregion Number_of_Stories_in_Building

#region Number_of_Apartments
var Number_of_Apartments = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Apartments",
	LogicalName = "lead_Number_of_Apartments",

	DisplayName = new Label("Number of Apartments", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Apartments", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Apartments);
#endregion Number_of_Apartments

#region Construction_Quality
var Construction_Quality = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Construction_Quality",
	LogicalName = "lead_Construction_Quality",

	DisplayName = new Label("Construction Quality", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Construction Quality", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Construction_Quality);
#endregion Construction_Quality

#region Building_Type
var Building_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Building_Type",
	LogicalName = "lead_Building_Type",

	DisplayName = new Label("Building Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Building Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Building_Type);
#endregion Building_Type

#region Primary_Improvement_Type
var Primary_Improvement_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Primary_Improvement_Type",
	LogicalName = "lead_Primary_Improvement_Type",

	DisplayName = new Label("Primary Improvement Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Primary Improvement Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Primary_Improvement_Type);
#endregion Primary_Improvement_Type

#region Property_Condition
var Property_Condition = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_Condition",
	LogicalName = "lead_Property_Condition",

	DisplayName = new Label("Property Condition", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property Condition", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Property_Condition);
#endregion Property_Condition

#region Construction_Type
var Construction_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Construction_Type",
	LogicalName = "lead_Construction_Type",

	DisplayName = new Label("Construction Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Construction Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Construction_Type);
#endregion Construction_Type

#region Exterior_Walls_Type
var Exterior_Walls_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Exterior_Walls_Type",
	LogicalName = "lead_Exterior_Walls_Type",

	DisplayName = new Label("Exterior Walls Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Exterior Walls Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Exterior_Walls_Type);
#endregion Exterior_Walls_Type

#region Land_plus_improvement_Value
var Land_plus_improvement_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Land_plus_improvement_Value",
	LogicalName = "lead_Land_plus_improvement_Value",

	DisplayName = new Label("Land plus improvement value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Land plus improvement value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Land_plus_improvement_Value);
#endregion Land_plus_improvement_Value

#region Property_Valuation_Type
var Property_Valuation_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_Valuation_Type",
	LogicalName = "lead_Property_Valuation_Type",

	DisplayName = new Label("Property Valuation Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property Valuation Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Property_Valuation_Type);
#endregion Property_Valuation_Type

#region Land_Value
var Land_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Land_Value",
	LogicalName = "lead_Land_Value",
	DisplayName = new Label("Land Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Land Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Land_Value);
#endregion Land_Value

#region Land_Value_Indicator
var Land_Value_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Land_Value_Indicator",
	LogicalName = "lead_Land_Value_Indicator",

	DisplayName = new Label("Land Value Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Land Value Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Land_Value_Indicator);
#endregion Land_Value_Indicator

#region Improvement_Value
var Improvement_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Improvement_Value",
	LogicalName = "lead_Improvement_Value",
	DisplayName = new Label("Improvement Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Improvement Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Improvement_Value);
#endregion Improvement_Value

#region Improvement_Value_Indicator
var Improvement_Value_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Improvement_Value_Indicator",
	LogicalName = "lead_Improvement_Value_Indicator",

	DisplayName = new Label("Improvement value indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Improvement value indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Improvement_Value_Indicator);
#endregion Improvement_Value_Indicator

#region Improvement_Value_Indicator
var Improvement_Value_Indicator = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Improvement_Value_Indicator",
	LogicalName = "lead_Improvement_Value_Indicator",
	DisplayName = new Label("Improvement Value Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Improvement Value Indicator", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Improvement_Value_Indicator);
#endregion Improvement_Value_Indicator

#region Assessed_Value
var Assessed_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Assessed_Value",
	LogicalName = "lead_Assessed_Value",
	DisplayName = new Label("Assessed value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Assessed value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Assessed_Value);
#endregion Assessed_Value

#region Assessed_Land_Value
var Assessed_Land_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Assessed_Land_Value",
	LogicalName = "lead_Assessed_Land_Value",
	DisplayName = new Label("Assessed Land Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Assessed Land Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Assessed_Land_Value);
#endregion Assessed_Land_Value

#region Assessed_Improvement_Value
var Assessed_Improvement_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Assessed_Improvement_Value",
	LogicalName = "lead_Assessed_Improvement_Value",
	DisplayName = new Label("Assessed Improvement Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Assessed Improvement Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Assessed_Improvement_Value);
#endregion Assessed_Improvement_Value

#region Total_Market_Value
var Total_Market_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Market_Value",
	LogicalName = "lead_Total_Market_Value",
	DisplayName = new Label("Total Market Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total Market Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Total_Market_Value);
#endregion Total_Market_Value

#region Market_Land_Values
var Market_Land_Values = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Market_Land_Values",
	LogicalName = "lead_Market_Land_Values",
	DisplayName = new Label("Market Land Values", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Market Land Values", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Market_Land_Values);
#endregion Market_Land_Values

#region Market_Improvement_Value
var Market_Improvement_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Market_Improvement_Value",
	LogicalName = "lead_Market_Improvement_Value",
	DisplayName = new Label("Market Improvement Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Market Improvement Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Market_Improvement_Value);
#endregion Market_Improvement_Value

#region Total_Appraised_Value
var Total_Appraised_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Appraised_Value",
	LogicalName = "lead_Total_Appraised_Value",
	DisplayName = new Label("Total Appraised Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total Appraised Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Total_Appraised_Value);
#endregion Total_Appraised_Value

#region Appraised_Land_Value
var Appraised_Land_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appraised_Land_Value",
	LogicalName = "lead_Appraised_Land_Value",
	DisplayName = new Label("Appraised Land Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appraised Land Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Appraised_Land_Value);
#endregion Appraised_Land_Value

#region Appraised_Improvement_Value
var Appraised_Improvement_Value = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appraised_Improvement_Value",
	LogicalName = "lead_Appraised_Improvement_Value",
	DisplayName = new Label("Appraised_Improvement_Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appraised_Improvement_Value", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Appraised_Improvement_Value);
#endregion Appraised_Improvement_Value

#region Year_Built
var Year_Built = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Year_Built",
	LogicalName = "lead_Year_Built",

	DisplayName = new Label("Year Built", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Year Built", _languageCode),
	MaxLength = 4,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Year_Built);
#endregion Year_Built

#region Effective_Year_Built
var Effective_Year_Built = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Effective_Year_Built",
	LogicalName = "lead_Effective_Year_Built",

	DisplayName = new Label("Effective Year Built", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Effective Year Built", _languageCode),
	MaxLength = 4,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Effective_Year_Built);
#endregion Effective_Year_Built

#region Property_View
var Property_View = new MemoAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Property_View",
	LogicalName = "lead_Property_View",
	DisplayName = new Label("Property View", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Property View", _languageCode),
	// Set extended properties
	Format = StringFormat.TextArea,
	ImeMode = ImeMode.Disabled,
	MaxLength = 500,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Property_View);
#endregion Property_View

#region Location_Associated_Aspects
var lead_Location_Associated_Aspects = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Location_Associated_Aspects",
	LogicalName = "lead_Location_Associated_Aspects",

	DisplayName = new Label("Location Associated Aspects", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Location Associated Aspects", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(lead_Location_Associated_Aspects);
#endregion Location_Associated_Aspects

#region Front_Linear_Feet
var Front_Linear_Feet = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Front_Linear_Feet",
	LogicalName = "lead_Front_Linear_Feet",

	DisplayName = new Label("Front Linear Feet", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Front Linear Feet", _languageCode),
	MaxLength = 2,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Front_Linear_Feet);
#endregion Front_Linear_Feet

#region Total_Acres
var Total_Acres = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Acres",
	LogicalName = "lead_Total_Acres",

	DisplayName = new Label("Total Acres", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total Acres", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Total_Acres);
#endregion Total_Acres

#region Land_Squarefeet
var Land_Squarefeet = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Land_Squarefeet",
	LogicalName = "lead_Land_Squarefeet",

	DisplayName = new Label("Land Square feet", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Lead Land Square feet", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Land_Squarefeet);
#endregion Land_Squarefeet

#region Building_Square_Footage
var Building_Square_Footage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Building_Square_Footage",
	LogicalName = "lead_Building_Square_Footage",

	DisplayName = new Label("Building Square Footage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Building Square Footage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Building_Square_Footage);
#endregion Building_Square_Footage

#region Building_Squarefeet
var Building_Squarefeet = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Building_Squarefeet",
	LogicalName = "lead_Building_Squarefeet",

	DisplayName = new Label("Building Squarefeet", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Building Squarefeet", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Building_Squarefeet);
#endregion Building_Squarefeet

#region Living_Squarefeet
var Living_Squarefeet = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Living_Squarefeet",
	LogicalName = "lead_Living_Squarefeet",

	DisplayName = new Label("Living Squarefeet", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Living Squarefeet", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Living_Squarefeet);
#endregion Living_Squarefeet

#region Square_Footage_Front
var Square_Footage_Front = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Square_Footage_Front",
	LogicalName = "lead_Square_Footage_Front",

	DisplayName = new Label("Square Footage Front", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Square Footage Front", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Square_Footage_Front);
#endregion Square_Footage_Front

#region Entire_Building_Square_Footage
var Entire_Building_Square_Footage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Entire_Building_Square_Footage",
	LogicalName = "lead_Entire_Building_Square_Footage",

	DisplayName = new Label("Entire Building Square Footage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Entire Building Square Footage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Entire_Building_Square_Footage);
#endregion Entire_Building_Square_Footage

#region Square_Footage_for_Improvement_Value
var Square_Footage_for_Improvement_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Square_Footage_for_Improvement_Value",
	LogicalName = "lead_Square_Footage_for_Improvement_Value",

	DisplayName = new Label("Square Footage for Improvement Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Square Footage for Improvement Value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Square_Footage_for_Improvement_Value);
#endregion Square_Footage_for_Improvement_Value

#region Basement_Square_Footage
var Basement_Square_Footage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Basement_Square_Footage",
	LogicalName = "lead_Basement_Square_Footage",

	DisplayName = new Label("Basement Square Footage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Basement Square Footage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Basement_Square_Footage);
#endregion Basement_Square_Footage

#region Square_footage_of_parking
var Square_footage_of_parking = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Square_footage_of_parking",
	LogicalName = "lead_Square_footage_of_parking",

	DisplayName = new Label("Square footage of parking", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Square footage of parking", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Square_footage_of_parking);
#endregion Square_footage_of_parking

#region Number_of_Room
var Number_of_Room = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Room",
	LogicalName = "lead_Number_of_Room",

	DisplayName = new Label("Number of Room", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Room", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Room);
#endregion Number_of_Room

#region Number_of_Bedroom
var Number_of_Bedroom = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Bedroom",
	LogicalName = "lead_Number_of_Bedroom",

	DisplayName = new Label("Number of Bedroom", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Bedroom", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Bedroom);
#endregion Number_of_Bedroom

#region Total_Number_of_Bathroom
var Total_Number_of_Bathroom = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Number_of_Bathroom",
	LogicalName = "lead_Total_Number_of_Bathroom",

	DisplayName = new Label("Total number of Bathroom", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total number of Bathroom", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Total_Number_of_Bathroom);
#endregion Total_Number_of_Bathroom

#region Number_of_Bathrooms
var Number_of_Bathrooms = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Bathrooms",
	LogicalName = "lead_Number_of_Bathrooms",

	DisplayName = new Label("Number of Bathrooms", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Bathrooms", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Bathrooms);
#endregion Number_of_Bathrooms

#region Total_Full_baths
var Total_Full_baths = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Full_baths",
	LogicalName = "lead_Total_Full_baths",

	DisplayName = new Label("Total Full baths", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total Full baths", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Total_Full_baths);
#endregion Total_Full_baths

#region Total_Half_baths
var Total_Half_baths = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_Half_baths",
	LogicalName = "lead_Total_Half_baths",

	DisplayName = new Label("Total Half baths", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total Half baths", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Total_Half_baths);
#endregion Total_Half_baths

#region Total_quarter_baths
var Total_quarter_baths = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Total_quarter_baths",
	LogicalName = "lead_Total_quarter_baths",

	DisplayName = new Label("Total quarter baths", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Total quarter baths", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Total_quarter_baths);
#endregion Total_quarter_baths

#region Number_of_3_quarter_baths
var Number_of_3_quarter_baths = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_3_quarter_baths",
	LogicalName = "lead_Number_of_3_quarter_baths",

	DisplayName = new Label("Number of 3 quarter baths", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of 3 quarter baths", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_3_quarter_baths);
#endregion Number_of_3_quarter_baths

#region Air_Conditioning_Type
var Air_Conditioning_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Air_Conditioning_Type",
	LogicalName = "lead_Air_Conditioning_Type",

	DisplayName = new Label("Air Conditioning Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Air Conditioning Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Air_Conditioning_Type);
#endregion Air_Conditioning_Type

#region Basement_Type
var Basement_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Basement_Type",
	LogicalName = "lead_Basement_Type",

	DisplayName = new Label("Basement Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Basement Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Basement_Type);
#endregion Basement_Type

#region Presence_of_Fireplace
var Presence_of_Fireplace = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Presence_of_Fireplace",
	LogicalName = "lead_Presence_of_Fireplace",

	DisplayName = new Label("Presence of Fireplace", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Presence of Fireplace", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Presence_of_Fireplace);
#endregion Presence_of_Fireplace

#region Type_of_Fireplace
var Type_of_Fireplace = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Type_of_Fireplace",
	LogicalName = "lead_Type_of_Fireplace",

	DisplayName = new Label("Type of Fireplace", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Type of Fireplace", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Type_of_Fireplace);
#endregion Type_of_Fireplace

#region Type_of_Foundation
var Type_of_Foundation = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Type_of_Foundation",
	LogicalName = "lead_Type_of_Foundation",

	DisplayName = new Label("Type of Foundation", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Type of Foundation", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Type_of_Foundation);
#endregion Type_of_Foundation

#region Floor_Construction_Type
var Floor_Construction_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Floor_Construction_Type",
	LogicalName = "lead_Floor_Construction_Type",

	DisplayName = new Label("Floor Construction Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Floor Construction Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Floor_Construction_Type);
#endregion Floor_Construction_Type

#region Type_of_Roof_Framing
var Type_of_Roof_Framing = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Type_of_Roof_Framing",
	LogicalName = "lead_Type_of_Roof_Framing",

	DisplayName = new Label("Type of Roof Framing", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Type of Roof Framing", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Type_of_Roof_Framing);
#endregion Type_of_Roof_Framing

#region Type_of_Garage
var Type_of_Garage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Type_of_Garage",
	LogicalName = "lead_Type_of_Garage",

	DisplayName = new Label("Type of Garage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Type of Garage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Type_of_Garage);
#endregion Type_of_Garage

#region Method_of_Heating
var Method_of_Heating = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Method_of_Heating",
	LogicalName = "lead_Method_of_Heating",

	DisplayName = new Label("Method of Heating", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Method of Heating", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Method_of_Heating);
#endregion Method_of_Heating

#region Number_of_Parking_Spaces
var Number_of_Parking_Spaces = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Parking_Spaces",
	LogicalName = "lead_Number_of_Parking_Spaces",

	DisplayName = new Label("Number of Parking Spaces", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Parking Spaces", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Parking_Spaces);
#endregion Number_of_Parking_Spaces

#region Parking_Type
var Parking_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Parking_Type",
	LogicalName = "lead_Parking_Type",

	DisplayName = new Label("Parking Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Parking Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Parking_Type);
#endregion Parking_Type

#region Presence_of_Pool
var Presence_of_Pool = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Presence_of_Pool",
	LogicalName = "lead_Presence_of_Pool",

	DisplayName = new Label("Presence of Pool", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Presence of Pool", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Presence_of_Pool);
#endregion Presence_of_Pool

#region Pool_Type
var Pool_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Pool_Type",
	LogicalName = "lead_Pool_Type",

	DisplayName = new Label("Pool Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Pool Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Pool_Type);
#endregion Pool_Type

#region Roof_Covering
var Roof_Covering = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Roof_Covering",
	LogicalName = "lead_Roof_Covering",

	DisplayName = new Label("Roof Covering", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Roof Covering", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Roof_Covering);
#endregion Roof_Covering

#region Roof_Type
var Roof_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Roof_Type",
	LogicalName = "lead_Roof_Type",

	DisplayName = new Label("Roof Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Roof Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Roof_Type);
#endregion Roof_Type

#region Type_of_Electricity
var Type_of_Electricity = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Type_of_Electricity",
	LogicalName = "lead_Type_of_Electricity",

	DisplayName = new Label("Type of Electricity", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Type of Electricity", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Type_of_Electricity);
#endregion Type_of_Electricity

#region Heating_Fuel_Type
var Heating_Fuel_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Heating_Fuel_Type",
	LogicalName = "lead_Heating_Fuel_Type",

	DisplayName = new Label("Heating Fuel Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Heating Fuel Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Heating_Fuel_Type);
#endregion Heating_Fuel_Type

#region Sewer_Type
var Sewer_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Sewer_Type",
	LogicalName = "lead_Sewer_Type",

	DisplayName = new Label("Sewer Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Sewer Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Sewer_Type);
#endregion Sewer_Type

#region Water_Supply_Type
var Water_Supply_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Water_Supply_Type",
	LogicalName = "lead_Water_Supply_Type",

	DisplayName = new Label("Water Supply Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Water Supply Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Water_Supply_Type);
#endregion Water_Supply_Type

#region Homestead_Qualified
var Homestead_Qualified = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Homestead_Qualified",
	LogicalName = "lead_Homestead_Qualified",

	DisplayName = new Label("Homestead Qualified", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Homestead Qualified", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Homestead_Qualified);
#endregion Homestead_Qualified

// Demographic Detail
#region Percent_Range_Black
var Percent_Range_Black = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_Black",
	LogicalName = "lead_Percent_Range_Black",

	DisplayName = new Label("Percent Range Black", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Black", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_Black);
#endregion Percent_Range_Black

#region Perfect_Range_White
var Perfect_Range_White = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Perfect_Range_White",
	LogicalName = "lead_Perfect_Range_White",

	DisplayName = new Label("Perfect Range White", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Perfect Range White", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Perfect_Range_White);
#endregion Perfect_Range_White

#region Percent_Range_Hispanic
var Percent_Range_Hispanic = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_Hispanic",
	LogicalName = "lead_Percent_Range_Hispanic",

	DisplayName = new Label("Percent Range Hispanic", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Hispanic", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_Hispanic);
#endregion Percent_Range_Hispanic

#region Pecent_Range_Asian
var Pecent_Range_Asian = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Pecent_Range_Asian",
	LogicalName = "lead_Pecent_Range_Asian",

	DisplayName = new Label("Percent Range Asian", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Asian", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Pecent_Range_Asian);
#endregion Pecent_Range_Asian

#region Percent_Range_English_Speaking
var Percent_Range_English_Speaking = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_English_Speaking",
	LogicalName = "lead_Percent_Range_English_Speaking",

	DisplayName = new Label("Percent Range English Speaking", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range English Speaking", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_English_Speaking);
#endregion Percent_Range_English_Speaking

#region Percent_Range_Spanish_Speaking
var Percent_Range_Spanish_Speaking = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_Spanish_Speaking",
	LogicalName = "lead_Percent_Range_Spanish_Speaking",

	DisplayName = new Label("Percent Range Spanish Speaking", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Spanish Speaking", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_Spanish_Speaking);
#endregion Percent_Range_Spanish_Speaking

#region Percent_Range_Asian_Speaking
var Percent_Range_Asian_Speaking = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_Asian_Speaking",
	LogicalName = "lead_Percent_Range_Asian_Speaking",

	DisplayName = new Label("Percent Range Asian Speaking", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Asian Speaking", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_Asian_Speaking);
#endregion Percent_Range_Asian_Speaking

#region Median_House_Value
var Median_House_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Median_House_Value",
	LogicalName = "lead_Median_House_Value",

	DisplayName = new Label("Median House Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Median House Value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Median_House_Value);
#endregion Median_House_Value

#region Medium_House_Value
var Medium_House_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Medium_House_Value",
	LogicalName = "lead_Medium_House_Value",

	DisplayName = new Label("Medium House Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Medium House Value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Medium_House_Value);
#endregion Medium_House_Value

#region Mail_Order_Respondent
var Mail_Order_Respondent = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mail_Order_Respondent",
	LogicalName = "lead_Mail_Order_Respondent",

	DisplayName = new Label("Mail Order Respondent", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mail Order Respondent", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mail_Order_Respondent);
#endregion Mail_Order_Respondent

#region Percent_Range_Automobile_Owner
var Percent_Range_Automobile_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Percent_Range_Automobile_Owner",
	LogicalName = "lead_Percent_Range_Automobile_Owner",

	DisplayName = new Label("Percent Range Automobile Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Percent Range Automobile Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Percent_Range_Automobile_Owner);
#endregion Percent_Range_Automobile_Owner

#region Median_Years_of_School
var Median_Years_of_School = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Median_Years_of_School",
	LogicalName = "lead_Median_Years_of_School",

	DisplayName = new Label("Median Years of School", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Median Years of School", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Median_Years_of_School);
#endregion Median_Years_of_School

#region Penetration_Range_White_Collar
var Penetration_Range_White_Collar = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Penetration_Range_White_Collar",
	LogicalName = "lead_Penetration_Range_White_Collar",

	DisplayName = new Label("Pentration Range White Collar", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Pentration Range White Collar", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Penetration_Range_White_Collar);
#endregion Penetration_Range_White_Collar

#region Penetration_Range_Blue_Collar
var Penetration_Range_Blue_Collar = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Penetration_Range_Blue_Collar",
	LogicalName = "lead_Penetration_Range_Blue_Collar",

	DisplayName = new Label("Penetration Range Blue Collar", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Penetration Range Blue Collar", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Penetration_Range_Blue_Collar);
#endregion Penetration_Range_Blue_Collar

#region Penetration_Range_Other_Occupation
var Penetration_Range_Other_Occupation = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Penetration_Range_Other_Occupation",
	LogicalName = "lead_Penetration_Range_Other_Occupation",

	DisplayName = new Label("Penetration Range Other Occupation", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Penetration Range Other Occupation", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Penetration_Range_Other_Occupation);
#endregion Penetration_Range_Other_Occupation

#region Score_Code
var Score_Code = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Score_Code",
	LogicalName = "lead_Score_Code",

	DisplayName = new Label("Score Code", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Score Code", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Score_Code);
#endregion Score_Code

#region Demographic_Level
var Demographic_Level = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Demographic_Level",
	LogicalName = "lead_Demographic_Level",

	DisplayName = new Label("Demographic Level", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Demographic Level", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Demographic_Level);
#endregion Demographic_Level

// Interests
#region Price_Club_and_value_Purchasing_Indicator
var Price_Club_and_value_Purchasing_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Price_Club_and_value_Purchasing_Indicator",
	LogicalName = "lead_Price_Club_and_value_Purchasing_Indicator",

	DisplayName = new Label("Price Club and value Purchasing Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Price Club and value Purchasing Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Price_Club_and_value_Purchasing_Indicator);
#endregion Price_Club_and_value_Purchasing_Indicator

#region Women_Apparel_Purchasing_Indicator
var Women_Apparel_Purchasing_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Women_Apparel_Purchasing_Indicator",
	LogicalName = "lead_Women_Apparel_Purchasing_Indicator",

	DisplayName = new Label("Women_Apparel_Purchasing_Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Women_Apparel_Purchasing_Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Women_Apparel_Purchasing_Indicator);
#endregion Women_Apparel_Purchasing_Indicator

#region Men_Apparel_Purchasing_Indicator
var Men_Apparel_Purchasing_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Men_Apparel_Purchasing_Indicator",
	LogicalName = "lead_Men_Apparel_Purchasing_Indicator",

	DisplayName = new Label("Men Apparel Purchasing Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Men Apparel Purchasing Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Men_Apparel_Purchasing_Indicator);
#endregion Men_Apparel_Purchasing_Indicator

#region Parenting_and_Children_Interest_Bundle
var Parenting_and_Children_Interest_Bundle = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Parenting_and_Children_Interest_Bundle",
	LogicalName = "lead_Parenting_and_Children_Interest_Bundle",

	DisplayName = new Label("Parenting and Children Interest Bundle", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Parenting and Children Interest Bundle", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Parenting_and_Children_Interest_Bundle);
#endregion Parenting_and_Children_Interest_Bundle

#region Pet_Lover_or_Owner
var Pet_Lover_or_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Pet_Lover_or_Owner",
	LogicalName = "lead_Pet_Lover_or_Owner",

	DisplayName = new Label("Pet Lover or Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Pet Lover or Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Pet_Lover_or_Owner);
#endregion Pet_Lover_or_Owner

#region Book_Buyers
var Book_Buyers = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Book_Buyers",
	LogicalName = "lead_Book_Buyers",

	DisplayName = new Label("Book Buyers", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Book Buyers", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Book_Buyers);
#endregion Book_Buyers

#region Book_Readers
var Book_Readers = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Book_Readers",
	LogicalName = "lead_Book_Readers",

	DisplayName = new Label("Book Readers", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Book Readers", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Book_Readers);
#endregion Book_Readers

#region Hi-Tech_Enthusiasts
var Hi-Tech_Enthusiasts = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Hi-Tech_Enthusiasts",
	LogicalName = "lead_Hi-Tech_Enthusiasts",

	DisplayName = new Label("Hi-Tech Enthusiasts", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Hi-Tech Enthusiasts", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Hi-Tech_Enthusiasts);
#endregion Hi-Tech_Enthusiasts

#region Arts_Bundle
var Arts_Bundle = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Arts_Bundle",
	LogicalName = "lead_Arts_Bundle",

	DisplayName = new Label("Arts Bundle", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Arts Bundle", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Arts_Bundle);
#endregion Arts_Bundle

#region Collectibles_Bundle
var Collectibles_Bundle = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Collectibles_Bundle",
	LogicalName = "lead_Collectibles_Bundle",

	DisplayName = new Label("Collectibles Bundle", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Collectibles Bundle", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Collectibles_Bundle);
#endregion Collectibles_Bundle

#region Hobbies_Home_and_Garden_Bundle
var Hobbies_Home_and_Garden_Bundle = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Hobbies_Home_and_Garden_Bundle",
	LogicalName = "lead_Hobbies_Home_and_Garden_Bundle",

	DisplayName = new Label("Hobbies Home and Garden Bundle", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Hobbies Home and Garden Bundle", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Hobbies_Home_and_Garden_Bundle);
#endregion Hobbies_Home_and_Garden_Bundle

#region Home_Improvement
var Home_Improvement = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Home_Improvement",
	LogicalName = "lead_Home_Improvement",

	DisplayName = new Label("Home Improvement", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Home Improvement", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Home_Improvement);
#endregion Home_Improvement

#region Cooking_and_Wine
var Cooking_and_Wine = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Cooking_and_Wine",
	LogicalName = "lead_Cooking_and_Wine",

	DisplayName = new Label("Cooking and Wine", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Cooking and Wine", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Cooking_and_Wine);
#endregion Cooking_and_Wine

#region Gaming_and_Gambling_Enthusiast
var Gaming_and_Gambling_Enthusiast = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Gaming_and_Gambling_Enthusiast",
	LogicalName = "lead_Gaming_and_Gambling_Enthusiast",

	DisplayName = new Label("Gaming and Gambling Enthusiast", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Gaming and Gambling Enthusiast", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Gaming_and_Gambling_Enthusiast);
#endregion Gaming_and_Gambling_Enthusiast

#region Travel_Enthusiasts
var Travel_Enthusiasts = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Travel_Enthusiasts",
	LogicalName = "lead_Travel_Enthusiasts",

	DisplayName = new Label("Travel Enthusiasts", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Travel Enthusiasts", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Travel_Enthusiasts);
#endregion Travel_Enthusiasts

#region Physical_Fitness
var Physical_Fitness = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Physical_Fitness",
	LogicalName = "lead_Physical_Fitness",

	DisplayName = new Label("Physical Fitness", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Physical Fitness", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Physical_Fitness);
#endregion Physical_Fitness

#region Self_Improvement
var Self_Improvement = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Self_Improvement",
	LogicalName = "lead_Self_Improvement",

	DisplayName = new Label("Self Improvement", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Self Improvement", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Self_Improvement);
#endregion Self_Improvement

#region Physical_Fitness
var Physical_Fitness = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Physical_Fitness",
	LogicalName = "lead_Physical_Fitness",

	DisplayName = new Label("Physical vFitness", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Physical vFitness", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Physical_Fitness);
#endregion Physical_Fitness

#region Automotive_DIY
var Automotive_DIY = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Automotive_DIY",
	LogicalName = "lead_Automotive_DIY",

	DisplayName = new Label("Automotive DIY", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Automotive DIY", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Automotive_DIY);
#endregion Automotive_DIY

#region Spectator_Sports_Interest
var Spectator_Sports_Interest = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Spectator_Sports_Interest",
	LogicalName = "lead_Spectator_Sports_Interest",

	DisplayName = new Label("Spectator Sports Interest", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Spectator Sports Interest", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Spectator_Sports_Interest);
#endregion Spectator_Sports_Interest

#region Outdoors
var Outdoors = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Outdoors",
	LogicalName = "lead_Outdoors",

	DisplayName = new Label("Outdoors", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Outdoors", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Outdoors);
#endregion Outdoors

#region Avid_Investors
var Avid_Investors = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Avid_Investors",
	LogicalName = "lead_Avid_Investors",

	DisplayName = new Label("Avid Investors", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Avid Investors", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Avid_Investors);
#endregion Avid_Investors

#region Avid_Interest_in_Boating
var Avid_Interest_in_Boating = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Avid_Interest_in_Boating",
	LogicalName = "lead_Avid_Interest_in_Boating",

	DisplayName = new Label("Avid Interest in Boating", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Avid Interest in Boating", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Avid_Interest_in_Boating);
#endregion Avid_Interest_in_Boating

#region Avid_Interest_in_Motorcyling
var Avid_Interest_in_Motorcyling = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Avid_Interest_in_Motorcyling",
	LogicalName = "lead_Avid_Interest_in_Motorcyling",

	DisplayName = new Label("Avid Interest in Motorcyling", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Avid Interest in Motorcyling", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Avid_Interest_in_Motorcyling);
#endregion Avid_Interest_in_Motorcyling

// Vehicle Information
#region Auto_Make
var Auto_Make = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Make",
	LogicalName = "lead_Auto_Make",

	DisplayName = new Label("Auto Make", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Make", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Make);
#endregion Auto_Make

#region Auto_Model
var Auto_Model = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Model",
	LogicalName = "lead_Auto_Model",

	DisplayName = new Label("Auto Model", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Model", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Model);
#endregion Auto_Model

#region Auto_Year
var Auto_Year = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Year",
	LogicalName = "lead_Auto_Year",

	DisplayName = new Label("Auto Year", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Year", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Year);
#endregion Auto_Year

#region Auto_Class
var Auto_Class = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Class",
	LogicalName = "lead_Auto_Class",

	DisplayName = new Label("Auto Class", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Class", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Class);
#endregion Auto_Class

#region Auto_Fuel_Type
var Auto_Fuel_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Fuel_Type",
	LogicalName = "lead_Auto_Fuel_Type",

	DisplayName = new Label("Auto Fuel Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Fuel Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Fuel_Type);
#endregion Auto_Fuel_Type

#region Auto_MFG
var Auto_MFG = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_MFG",
	LogicalName = "lead_Auto_MFG",

	DisplayName = new Label("Auto MFG", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto MFG", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_MFG);
#endregion Auto_MFG

#region Auto_Style
var Auto_Style = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Style",
	LogicalName = "lead_Auto_Style",

	DisplayName = new Label("Auto Style", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Style", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Style);
#endregion Auto_Style

#region Auto_Mileage
var Auto_Mileage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Auto_Mileage",
	LogicalName = "lead_Auto_Mileage",

	DisplayName = new Label("Auto Mileage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Auto Mileage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Auto_Mileage);
#endregion Auto_Mileage

#region Last_Verified_Date
var Last_Verified_Date = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Last_Verified_Date",
	LogicalName = "lead_Last_Verified_Date",

	DisplayName = new Label("Last Verified Date", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Last Verified Date", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Last_Verified_Date);
#endregion Last_Verified_Date

#region Second_Auto_Make
var Second_Auto_Make = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Make",
	LogicalName = "lead_Second_Auto_Make",

	DisplayName = new Label("Second Auto Make", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Make", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Make);
#endregion Second_Auto_Make

#region Second_Auto_Model
var Second_Auto_Model = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Model",
	LogicalName = "lead_Second_Auto_Model",

	DisplayName = new Label("Second Auto Model", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Model", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Model);
#endregion Second_Auto_Model

#region Second_Auto_Year
var Second_Auto_Year = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Year",
	LogicalName = "lead_Second_Auto_Year",

	DisplayName = new Label("Second Auto Year", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Year", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Year);
#endregion Second_Auto_Year

#region Second_Auto_Class
var Second_Auto_Class = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Class",
	LogicalName = "lead_Second_Auto_Class",

	DisplayName = new Label("Second Auto Class", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Class", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Class);
#endregion Second_Auto_Class

#region Second_Auto_Fuel_Type
var Second_Auto_Fuel_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Fuel_Type",
	LogicalName = "lead_Second_Auto_Fuel_Type",

	DisplayName = new Label("Second Auto Fuel Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Fuel Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Fuel_Type);
#endregion Second_Auto_Fuel_Type

#region Second_Auto_MFG
var Second_Auto_MFG = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_MFG",
	LogicalName = "lead_Second_Auto_MFG",

	DisplayName = new Label("Second Auto MFG", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto MFG", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_MFG);
#endregion Second_Auto_MFG

#region Second_Auto_Style
var Second_Auto_Style = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Style",
	LogicalName = "lead_Second_Auto_Style",

	DisplayName = new Label("Second Auto Style", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Style", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Style);
#endregion Second_Auto_Style

#region Second_Auto_Mileage
var Second_Auto_Mileage = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Mileage",
	LogicalName = "lead_Second_Auto_Mileage",

	DisplayName = new Label("Second Auto Mileage", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Mileage", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Mileage);
#endregion Second_Auto_Mileage

#region Second_Auto_Last_Verified_Date
var Second_Auto_Last_Verified_Date = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Second_Auto_Last_Verified_Date",
	LogicalName = "lead_Second_Auto_Last_Verified_Date",

	DisplayName = new Label("Second Auto Last Verified Date", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Second Auto Last Verified Date", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Second_Auto_Last_Verified_Date);
#endregion Second_Auto_Last_Verified_Date

#region Luxury_vehicle_Owner
var Luxury_vehicle_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Luxury_vehicle_Owner",
	LogicalName = "lead_Luxury_vehicle_Owner",

	DisplayName = new Label("Luxury Vehicle Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Luxury Vehicle Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Luxury_vehicle_Owner);
#endregion Luxury_vehicle_Owner

#region SUV_Owner
var SUV_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_SUV_Owner",
	LogicalName = "lead_SUV_Owner",

	DisplayName = new Label("SUV Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("SUV Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(SUV_Owner);
#endregion SUV_Owner

#region Pickup_Truck_Owner
var Pickup_Truck_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Pickup_Truck_Owner",
	LogicalName = "lead_Pickup_Truck_Owner",

	DisplayName = new Label("Pickup Truck Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Pickup Truck Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Pickup_Truck_Owner);
#endregion Pickup_Truck_Owner


// Property Information

#region Legal_Description
var Legal_Description = new MemoAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Legal_Description",
	LogicalName = "lead_Legal_Description",
	DisplayName = new Label("Legal Description", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Legal Description", _languageCode),
	// Set extended properties
	Format = StringFormat.TextArea,
	ImeMode = ImeMode.Disabled,
	MaxLength = 500,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Legal_Description);
#endregion Legal_Description

#region Dwelling_Type
var Dwelling_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Dwelling_Type",
	LogicalName = "lead_Dwelling_Type",

	DisplayName = new Label("Dwelling_Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Dwelling_Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Dwelling_Type);
#endregion Dwelling_Type

#region Length_of_Residence
var Length_of_Residence = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Length_of_Residence",
	LogicalName = "lead_Length_of_Residence",

	DisplayName = new Label("Length_of_Residence", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Length_of_Residence", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Length_of_Residence);
#endregion Length_of_Residence

#region Median_Year_Built
var Median_Year_Built = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Median_Year_Built",
	LogicalName = "lead_Median_Year_Built",

	DisplayName = new Label("Median Year Built", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Median Year Built", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Median_Year_Built);
#endregion Median_Year_Built

#region Mobile_Home_Indicator
var Mobile_Home_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mobile_Home_Indicator",
	LogicalName = "lead_Mobile_Home_Indicator",

	DisplayName = new Label("Mobile Home Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mobile Home Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mobile_Home_Indicator);
#endregion Mobile_Home_Indicator

#region Pool_Owner
var Pool_Owner = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Pool_Owner",
	LogicalName = "lead_Pool_Owner",

	DisplayName = new Label("Pool Owner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Pool Owner", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Pool_Owner);
#endregion Pool_Owner

#region Fireplace_in_Home
var Fireplace_in_Home = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Fireplace_in_Home",
	LogicalName = "lead_Fireplace_in_Home",

	DisplayName = new Label("Fireplace in Home", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Fireplace in Home", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Fireplace_in_Home);
#endregion Fireplace_in_Home

#region Absentee_Own_Indicator
var Absentee_Own_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Absentee_Own_Indicator",
	LogicalName = "lead_Absentee_Own_Indicator",

	DisplayName = new Label("Absentee Own Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Absentee Own Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Absentee_Own_Indicator);
#endregion Absentee_Own_Indicator

#region Home_Market_Value
var Home_Market_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Home_Market_Value",
	LogicalName = "lead_Home_Market_Value",

	DisplayName = new Label("Home Market Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Home Market Value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Home_Market_Value);
#endregion Home_Market_Value

#region Absentee_Owner_Indicator
var Absentee_Owner_Indicator = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Absentee_Owner_Indicator",
	LogicalName = "lead_Absentee_Owner_Indicator",

	DisplayName = new Label("Absentee Owner Indicator", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Absentee Owner Indicator", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Absentee_Owner_Indicator);
#endregion Absentee_Owner_Indicator

#region Equity_In_Property
var Equity_In_Property = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Equity_In_Property",
	LogicalName = "lead_Equity_In_Property",

	DisplayName = new Label("Equity In Property", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Equity In Property", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Equity_In_Property);
#endregion Equity_In_Property

#region Equity_In_Property
var Equity_In_Property = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Equity_In_Property",
	LogicalName = "lead_Equity_In_Property",
	DisplayName = new Label("Equity In Property", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Equity In Property", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Equity_In_Property);
#endregion Equity_In_Property

#region Tax_Amount
var Tax_Amount = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Tax_Amount",
	LogicalName = "lead_Tax_Amount",
	DisplayName = new Label("Tax Amount", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Tax Amount", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Tax_Amount);
#endregion Tax_Amount

#region Tax_Year
var Tax_Year = new DateTimeAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Tax_Year",
	LogicalName = "lead_Tax_Year",
	DisplayName = new Label("Tax Year", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Tax Year", _languageCode),
	// Set extended properties
	Format = DateTimeFormat.DateOnly,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Tax_Year);
#endregion Tax_Year

#region Sale_Year
var Sale_Year = new DateTimeAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Sale_Year",
	LogicalName = "lead_Sale_Year",
	DisplayName = new Label("Sale Year", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Sale Year", _languageCode),
	// Set extended properties
	Format = DateTimeFormat.DateOnly,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Sale_Year);
#endregion Sale_Year

#region Last_Assessment_Year
var Last_Assessment_Year = new DateTimeAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Last_Assessment_Year",
	LogicalName = "lead_Last_Assessment_Year",
	DisplayName = new Label("Last Assessment Year", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Last Assessment Year", _languageCode),
	// Set extended properties
	Format = DateTimeFormat.DateOnly,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Last_Assessment_Year);
#endregion Last_Assessment_Year

#region Seller_Carry_Back
var Seller_Carry_Back = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Seller_Carry_Back",
	LogicalName = "lead_Seller_Carry_Back",

	DisplayName = new Label("Seller Carry Back", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Seller Carry Back", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Seller_Carry_Back);
#endregion Seller_Carry_Back

#region Title_Company
var Title_Company = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Title_Company",
	LogicalName = "lead_Title_Company",

	DisplayName = new Label("Title Company", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Title Company", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Title_Company);
#endregion Title_Company

// Mortgage Information
#region Mortgage_Information1

#region Mortgage_Amount1
var Mortgage_Amount1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount1",
	LogicalName = "lead_Mortgage_Amount1",

	DisplayName = new Label("Mortgage Amount 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount1);
#endregion Mortgage_Amount1

#region Mortgage_Date1
var Mortgage_Date1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Date1",
	LogicalName = "lead_Mortgage_Date1",

	DisplayName = new Label("Mortgage Date 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Date 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Date1);
#endregion Mortgage_Date1

#region Mortgage_Type1
var Mortgage_Type1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Type1",
	LogicalName = "lead_Mortgage_Type1",

	DisplayName = new Label("Mortgage Type 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Type 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Type1);
#endregion Mortgage_Type1

#region Mortgage_Deed_Type1
var Mortgage_Deed_Type1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Deed_Type1",
	LogicalName = "lead_Mortgage_Deed_Type1",

	DisplayName = new Label("Mortgage Deed Type 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Deed Type 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Deed_Type1);
#endregion Mortgage_Deed_Type1

#region Mortgage_Term1
var Mortgage_Term1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Term1",
	LogicalName = "lead_Mortgage_Term1",

	DisplayName = new Label("Mortgage Term 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Term 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Term1);
#endregion Mortgage_Term1

#region Mortgage_Due_Date1
var Mortgage_Due_Date1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Due_Date1",
	LogicalName = "lead_Mortgage_Due_Date1",

	DisplayName = new Label("Mortgage Due Date 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Due Date 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Due_Date1);
#endregion Mortgage_Due_Date1

#region Mortgage_Amount_Assumed1
var Mortgage_Amount_Assumed1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount_Assumed1",
	LogicalName = "lead_Mortgage_Amount_Assumed1",

	DisplayName = new Label("Mortgage Amount Assumed 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount Assumed 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount_Assumed1);
#endregion Mortgage_Amount_Assumed1

#region Lender_Name1
var Lender_Name1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Lender_Name1",
	LogicalName = "lead_Lender_Name1",

	DisplayName = new Label("Lender Name 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Lender Name 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Lender_Name1);
#endregion Lender_Name1

#region Refi_Type1
var Refi_Type1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Refi_Type1",
	LogicalName = "lead_Refi_Type1",

	DisplayName = new Label("Refi Type 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Refi Type 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Refi_Type1);
#endregion Refi_Type1

#region Mortgage_Interest_Rate1
var Mortgage_Interest_Rate1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Interest_Rate1",
	LogicalName = "lead_Mortgage_Interest_Rate1",

	DisplayName = new Label("Mortgage Interest Rate 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Interest Rate 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Interest_Rate1);
#endregion Mortgage_Interest_Rate1

#region Mortgage_Rate_Type1
var Mortgage_Rate_Type1 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Rate_Type1",
	LogicalName = "lead_Mortgage_Rate_Type1",

	DisplayName = new Label("Mortgage Rate Type 1", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Rate Type 1", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Rate_Type1);
#endregion Mortgage_Rate_Type1


#endregion Mortgage_Information1

#region Mortgage_Information2

#region Mortgage_Amount2
var Mortgage_Amount2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount2",
	LogicalName = "lead_Mortgage_Amount2",

	DisplayName = new Label("Mortgage Amount 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount2);
#endregion Mortgage_Amount2

#region Mortgage_Date2
var Mortgage_Date2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Date2",
	LogicalName = "lead_Mortgage_Date2",

	DisplayName = new Label("Mortgage Date 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Date 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Date2);
#endregion Mortgage_Date2

#region Mortgage_Type2
var Mortgage_Type2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Type2",
	LogicalName = "lead_Mortgage_Type2",

	DisplayName = new Label("Mortgage Type 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Type 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Type2);
#endregion Mortgage_Type2

#region Mortgage_Deed_Type2
var Mortgage_Deed_Type2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Deed_Type2",
	LogicalName = "lead_Mortgage_Deed_Type2",

	DisplayName = new Label("Mortgage Deed Type 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Deed Type 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Deed_Type2);
#endregion Mortgage_Deed_Type2

#region Mortgage_Term2
var Mortgage_Term2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Term2",
	LogicalName = "lead_Mortgage_Term2",

	DisplayName = new Label("Mortgage Term 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Term 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Term2);
#endregion Mortgage_Term2

#region Mortgage_Due_Date2
var Mortgage_Due_Date2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Due_Date2",
	LogicalName = "lead_Mortgage_Due_Date2",

	DisplayName = new Label("Mortgage Due Date 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Due Date 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Due_Date2);
#endregion Mortgage_Due_Date2

#region Mortgage_Amount_Assumed2
var Mortgage_Amount_Assumed2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount_Assumed2",
	LogicalName = "lead_Mortgage_Amount_Assumed2",

	DisplayName = new Label("Mortgage Amount Assumed 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount Assumed 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount_Assumed2);
#endregion Mortgage_Amount_Assumed2

#region Lender_Name2
var Lender_Name2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Lender_Name2",
	LogicalName = "lead_Lender_Name2",

	DisplayName = new Label("Lender Name 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Lender Name 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Lender_Name2);
#endregion Lender_Name2

#region Refi_Type2
var Refi_Type2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Refi_Type2",
	LogicalName = "lead_Refi_Type2",

	DisplayName = new Label("Refi Type 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Refi Type 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Refi_Type2);
#endregion Refi_Type2

#region Mortgage_Interest_Rate2
var Mortgage_Interest_Rate2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Interest_Rate2",
	LogicalName = "lead_Mortgage_Interest_Rate2",

	DisplayName = new Label("Mortgage Interest Rate 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Interest Rate 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Interest_Rate2);
#endregion Mortgage_Interest_Rate2

#region Mortgage_Rate_Type2
var Mortgage_Rate_Type2 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Rate_Type2",
	LogicalName = "lead_Mortgage_Rate_Type2",

	DisplayName = new Label("Mortgage Rate Type 2", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Rate Type 2", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Rate_Type2);
#endregion Mortgage_Rate_Type2

#endregion Mortgage_Information2

#region Mortgage_Information3

#region Mortgage_Amount3
var Mortgage_Amount3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount3",
	LogicalName = "lead_Mortgage_Amount3",

	DisplayName = new Label("Mortgage Amount 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount3);
#endregion Mortgage_Amount3

#region Mortgage_Date3
var Mortgage_Date3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Date3",
	LogicalName = "lead_Mortgage_Date3",

	DisplayName = new Label("Mortgage Date 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Date 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Date3);
#endregion Mortgage_Date3

#region Mortgage_Type3
var Mortgage_Type3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Type3",
	LogicalName = "lead_Mortgage_Type3",

	DisplayName = new Label("Mortgage Type 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Type 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Type3);
#endregion Mortgage_Type3

#region Mortgage_Deed_Type3
var Mortgage_Deed_Type3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Deed_Type3",
	LogicalName = "lead_Mortgage_Deed_Type3",

	DisplayName = new Label("Mortgage Deed Type 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Deed Type 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Deed_Type3);
#endregion Mortgage_Deed_Type3

#region Mortgage_Term3
var Mortgage_Term3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Term3",
	LogicalName = "lead_Mortgage_Term3",

	DisplayName = new Label("Mortgage Term 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Term 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Term3);
#endregion Mortgage_Term3

#region Mortgage_Due_Date3
var Mortgage_Due_Date3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Due_Date3",
	LogicalName = "lead_Mortgage_Due_Date3",

	DisplayName = new Label("Mortgage Due Date 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Due Date 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Due_Date3);
#endregion Mortgage_Due_Date3

#region Mortgage_Amount_Assumed3
var Mortgage_Amount_Assumed3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Amount_Assumed3",
	LogicalName = "lead_Mortgage_Amount_Assumed3",

	DisplayName = new Label("Mortgage Amount Assumed 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Amount Assumed 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Amount_Assumed3);
#endregion Mortgage_Amount_Assumed3

#region Lender_Name3
var Lender_Name3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Lender_Name3",
	LogicalName = "lead_Lender_Name3",

	DisplayName = new Label("Lender Name 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Lender Name 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Lender_Name3);
#endregion Lender_Name3

#region Refi_Type3
var Refi_Type3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Refi_Type3",
	LogicalName = "lead_Refi_Type3",

	DisplayName = new Label("Refi Type 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Refi Type 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Refi_Type3);
#endregion Refi_Type3

#region Mortgage_Interest_Rate3
var Mortgage_Interest_Rate3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Interest_Rate3",
	LogicalName = "lead_Mortgage_Interest_Rate3",

	DisplayName = new Label("Mortgage Interest Rate 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Interest Rate 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Interest_Rate3);
#endregion Mortgage_Interest_Rate3

#region Mortgage_Rate_Type3
var Mortgage_Rate_Type3 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Mortgage_Rate_Type3",
	LogicalName = "lead_Mortgage_Rate_Type3",

	DisplayName = new Label("Mortgage Rate Type 3", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Mortgage Rate Type 3", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Mortgage_Rate_Type3);
#endregion Mortgage_Rate_Type3

#endregion Mortgage_Information3

// Personal Details

#region Deceased
var Deceased = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Deceased",
	LogicalName = "lead_Deceased",
	DisplayName = new Label("Deceased", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Deceased", _languageCode),
	// Set extended properties
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Deceased);
#endregion Deceased

#region Gender
var Gender = new PicklistAttributeMetadata
	{
		// Set base properties
		SchemaName = "lead_Gender",
		LogicalName = "lead_Gender",
		DisplayName = new Label("Gender", _languageCode),
		RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
		Description = new Label("Gender", _languageCode),
		// Set extended properties
		// Build local picklist options
		OptionSet = new OptionSetMetadata {
			IsGlobal = false,
			OptionSetType = OptionSetType.Picklist,
			Options = {
			new OptionMetadata( new Label("Male", _languageCode), null),
			new OptionMetadata( new Label("Female", _languageCode), null),
			new OptionMetadata( new Label("Other", _languageCode), null),
			}
		}
	};

// Add to list
addedAttributes.Add(Gender);
#endregion Gender

#region Ethnicity
var Ethnicity = new PicklistAttributeMetadata
	{
		// Set base properties
		SchemaName = "lead_Ethnicity",
		LogicalName = "lead_Ethnicity",
		DisplayName = new Label("Ethnicity", _languageCode),
		RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
		Description = new Label("Ethnicity", _languageCode),
		OptionSet = new OptionSetMetadata {
			IsGlobal = false,
			OptionSetType = OptionSetType.Picklist,
			Options = {
			new OptionMetadata( new Label("F", _languageCode), null),
			new OptionMetadata( new Label("A", _languageCode), null),
			new OptionMetadata( new Label("Y", _languageCode), null),
			}
		}
	};

// Add to list
addedAttributes.Add(Ethnicity);
#endregion Ethnicity

#region Presence_of_Children
var Presence_of_Children = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Presence_of_Children",
	LogicalName = "lead_Presence_of_Children",
	DisplayName = new Label("Presence of Children", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Presence of Children", _languageCode),
	// Set extended properties
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Presence_of_Children);
#endregion Presence_of_Children

#region Number_of_Children
var Number_of_Children = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Number_of_Children",
	LogicalName = "lead_Number_of_Children",

	DisplayName = new Label("Number of Children", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Number of Children", _languageCode),
	MaxLength = 5,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Number_of_Children);
#endregion Number_of_Children

#region Child_Age_Ranges
var Child_Age_Ranges = new MultiSelectPicklistAttributeMetadata()
{
	SchemaName = "lead_Child_Age_Ranges",
	LogicalName = "lead_Child_Age_Ranges",
	DisplayName = new Label("Child Age Ranges", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Child Age Ranges", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new OptionSetMetadata()
	{
		IsGlobal = false,
		OptionSetType = OptionSetType.Picklist,
		Options = {
			new OptionMetadata(new Label("01-10",_languageCode),null),
			new OptionMetadata(new Label("10-20",_languageCode),null),
			new OptionMetadata(new Label("20-30",_languageCode),null),
		}
	}
};
// Add to list
addedAttributes.Add(Child_Age_Ranges);
#endregion Child_Age_Ranges

#region Homeowner
var Homeowner = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Homeowner",
	LogicalName = "lead_Homeowner",
	DisplayName = new Label("Homeowner", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Homeowner", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	// Set extended properties
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("H", _languageCode), null),
		new OptionMetadata(new Label("R", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Homeowner);
#endregion Homeowner

#region Estimated_Household_Income
var Estimated_Household_Income = new MoneyAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Estimated_Household_Income",
	LogicalName = "lead_Estimated_Household_Income",
	DisplayName = new Label("Estimated Household Income", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Estimated Household Income", _languageCode),
	// Set extended properties
	MinValue = 0.00,
	Precision = 1,
	PrecisionSource = 1,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
    IsValidForGrid = true,
};

// Add to list
addedAttributes.Add(Estimated_Household_Income);
#endregion Estimated_Household_Income

#region Estimated_Household_Income
var Estimated_Household_Income = new MultiSelectPicklistAttributeMetadata()
{
	SchemaName = "lead_Estimated_Household_Income",
	LogicalName = "lead_Estimated_Household_Income",
	DisplayName = new Label("Estimated_Household_Income", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
	Description = new Label("Estimated_Household_Income", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new OptionSetMetadata()
	{
		IsGlobal = false,
		OptionSetType = OptionSetType.Picklist,
		Options = {
					new OptionMetadata(new Label("A",_languageCode),null),
					new OptionMetadata(new Label("B",_languageCode),null),
					new OptionMetadata(new Label("S",_languageCode),null)
					new OptionMetadata(new Label("M",_languageCode),null)
		}
	}
};
// Add to list
addedAttributes.Add(Estimated_Household_Income);
#endregion Estimated_Household_Income

#region Single_Parent
var Single_Parent = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Single_Parent",
	LogicalName = "lead_Single_Parent",
	DisplayName = new Label("Single Parent", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Single Parent", _languageCode),
	// Set extended properties
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Single_Parent);
#endregion Single_Parent

#region Senior_in_Household
var Senior_in_Household = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Senior_in_Household",
	LogicalName = "lead_Senior_in_Household",
	DisplayName = new Label("Senior in Household", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Senior in Household", _languageCode),
	// Set extended properties
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Senior_in_Household);
#endregion Senior_in_Household

#region Education
var Education = new MultiSelectPicklistAttributeMetadata()
{
	SchemaName = "lead_Education",
	LogicalName = "lead_Education",
	DisplayName = new Label("Education", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Education", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new OptionSetMetadata()
	{
		IsGlobal = false,
		OptionSetType = OptionSetType.Picklist,
		Options = {
					new OptionMetadata(new Label("A",_languageCode),null),
					new OptionMetadata(new Label("B",_languageCode),null),
					new OptionMetadata(new Label("C",_languageCode),null)
					new OptionMetadata(new Label("D",_languageCode),null)
		}
	}
};
// Add to list
addedAttributes.Add(Education);
#endregion Education

#region Credit_Card_User
var Credit_Card_User = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Credit_Card_User",
	LogicalName = "lead_Credit_Card_User",
	DisplayName = new Label("Credit Card User", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Credit Card User", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Credit_Card_User);
#endregion Credit_Card_User

#region Wealth_Score
var Wealth_Score = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Wealth_Score",
	LogicalName = "lead_Wealth_Score",
	DisplayName = new Label("Wealth Score", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Wealth Score", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Wealth_Score);
#endregion Wealth_Score

#region Donator_to_Charity_or_Causes
var Donator_to_Charity_or_Causes = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Donator_to_Charity_or_Causes",
	LogicalName = "lead_Donator_to_Charity_or_Causes",
	DisplayName = new Label("Donator to Charity or Causes", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Donator to Charity or Causes", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Donator_to_Charity_or_Causes);
#endregion Donator_to_Charity_or_Causes

#region Combat_Veteran
var Combat_Veteran = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Combat_Veteran",
	LogicalName = "lead_Combat_Veteran",
	DisplayName = new Label("Combat Veteran", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Combat Veteran", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Combat_Veteran);
#endregion Combat_Veteran

#region Disabled
var Disabled = new BooleanAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Disabled",
	LogicalName = "lead_Disabled",
	DisplayName = new Label("Disabled", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Disabled", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new BooleanOptionSetMetadata(
		new OptionMetadata(new Label("Yes", _languageCode), null),
		new OptionMetadata(new Label("No", _languageCode), null)
		)
};

// Add to list
addedAttributes.Add(Disabled);
#endregion Disabled

#region Loan_To_Value
var Loan_To_Value = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Loan_To_Value",
	LogicalName = "lead_Loan_To_Value",

	DisplayName = new Label("Loan To Value", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Loan To Value", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Loan_To_Value);
#endregion Loan_To_Value

#region Appended_House_Number
var Appended_House_Number = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_House_Number",
	LogicalName = "lead_Appended_House_Number",

	DisplayName = new Label("Appended House Number", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended House Number", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_House_Number);
#endregion Appended_House_Number

#region Appended_HStreet_Name
var Appended_Street_Name = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Street_Name",
	LogicalName = "lead_Appended_Street_Name",

	DisplayName = new Label("Appended Street Name", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Street Name", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_Street_Name);
#endregion Appended_Street_Name

#region Appended_Street_Type
var Appended_Street_Type = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Street_Type",
	LogicalName = "lead_Appended_Street_Type",

	DisplayName = new Label("Appended Street Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Street Type", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_Street_Type);
#endregion Appended_Street_Type

#region Appended_Post_Directional
var Appended_Post_Directional = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Post_Directional",
	LogicalName = "lead_Appended_Post_Directional",

	DisplayName = new Label("Appended_Post_Directional", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended_Post_Directional", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_Post_Directional);
#endregion Appended_Post_Directional

#region Appended_City
var Appended_City = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_City",
	LogicalName = "lead_Appended_City",

	DisplayName = new Label("Appended City", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended City", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_City);
#endregion Appended_City

#region Appended_State
var Appended_State = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_State",
	LogicalName = "lead_Appended_State",

	DisplayName = new Label("Appended State", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended State", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_State);
#endregion Appended_State

#region Appended_Zip5
var Appended_Zip5 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Zip5",
	LogicalName = "lead_Appended_Zip5",

	DisplayName = new Label("Appended Zip 5", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Zip 5", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_Zip5);
#endregion Appended_Zip5

#region Appended_Zip4
var Appended_Zip4 = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Zip4",
	LogicalName = "lead_Appended_Zip4",

	DisplayName = new Label("Appended Zip 4", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Zip 4", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,

};
addedAttributes.Add(Appended_Zip4);
#endregion Appended_Zip4

#region Appended_Phone
// Create a memo attribute
var Appended_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Phone",
	LogicalName = "lead_Appended_Phone",
	DisplayName = new Label("Appended Phone", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired),
	Description = new Label("Appended Phone", _languageCode),
	// Set extended properties
	Format = StringFormat.Phone,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
	IsValidForGrid = true,
	MaxLength = 25,
};
addedAttributes.Add(Appended_Phone);
#endregion Appended_Phone

#region Appended_Phone_Type
var Appended_Phone_Type = new PicklistAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Phone_Type",
	LogicalName = "lead_Appended_Phone_Type",
	DisplayName = new Label("Appended_Phone_Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended_Phone_Type", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new OptionSetMetadata {
		IsGlobal = false,
		OptionSetType = OptionSetType.Picklist,
		Options = {
		new OptionMetadata( new Label("Landline", _languageCode), null),
		new OptionMetadata( new Label("Mobile", _languageCode), null),
		}
	}
};
addedAttributes.Add(Appended_Phone_Type);
#endregion Appended_Phone_Type

#region Appended_Second_Phone
// Create a memo attribute
var Appended_Second_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Second_Phone",
	LogicalName = "lead_Appended_Second_Phone",
	DisplayName = new Label("Appended Phone(second)", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired),
	Description = new Label("Appended Phone(second)", _languageCode),
	// Set extended properties
	Format = StringFormat.Phone,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
	IsValidForGrid = true,
	MaxLength = 25,
};
addedAttributes.Add(Appended_Second_Phone);
#endregion Appended_Second_Phone

#region Appended_Second_Phone_Type
var Appended_Second_Phone_Type = new PicklistAttributeMetadata
	{
		// Set base properties
		SchemaName = "lead_Appended_Second_Phone_Type",
		LogicalName = "lead_Appended_Second_Phone_Type",
		DisplayName = new Label("Appended Second Phone Type", _languageCode),
		RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
		Description = new Label("Appended Second Phone Type", _languageCode),
		IsValidForForm = true,
		IsValidForGrid = true,
		OptionSet = new OptionSetMetadata {
			IsGlobal = false,
			OptionSetType = OptionSetType.Picklist,
			Options = {
			new OptionMetadata( new Label("Landline", _languageCode), null),
			new OptionMetadata( new Label("Mobile", _languageCode), null),
			}
		}
	};

// Add to list
addedAttributes.Add(Appended_Second_Phone_Type);
#endregion Appended_Second_Phone_Type

#region Appended_Third_Phone
var Appended_Third_Phone = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Third_Phone",
	LogicalName = "lead_Appended_Third_Phone",
	DisplayName = new Label("Appended Phone(Third)", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired),
	Description = new Label("Appended Phone(Third)", _languageCode),
	// Set extended properties
	Format = StringFormat.Phone,
	ImeMode = ImeMode.Disabled,
	IsValidForForm = true,
	IsValidForGrid = true,
	MaxLength = 25,
};
addedAttributes.Add(Appended_Third_Phone);
#endregion Appended_Third_Phone

#region Appended_Third_Phone_Type
var Appended_Third_Phone_Type = new PicklistAttributeMetadata
{
	SchemaName = "lead_Appended_Third_Phone_Type",
	LogicalName = "lead_Appended_Third_Phone_Type",
	DisplayName = new Label("Appended Third Phone Type", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Third Phone Type", _languageCode),
	IsValidForForm = true,
	IsValidForGrid = true,
	OptionSet = new OptionSetMetadata {
		IsGlobal = false,
		OptionSetType = OptionSetType.Picklist,
		Options = {
		new OptionMetadata( new Label("Landline", _languageCode), null),
		new OptionMetadata( new Label("Mobile", _languageCode), null),
		}
	}
};
addedAttributes.Add(Appended_Third_Phone_Type);
#endregion Appended_Third_Phone_Type

#region Appended_Email
var Appended_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Email",
	LogicalName = "lead_Appended_Email",

	DisplayName = new Label("Appended Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,
	Format = StringFormat.Email,
};
addedAttributes.Add(Appended_Email);
#endregion Appended_Email

#region Appended_Second_Email
var Appended_Second_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Second_Email",
	LogicalName = "lead_Appended_Second_Email",

	DisplayName = new Label("Appended Second Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Second Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,
	Format = StringFormat.Email,
};
addedAttributes.Add(Appended_Second_Email);
#endregion Appended_Second_Email

#region Appended_Third_Email
var Appended_Third_Email = new StringAttributeMetadata
{
	// Set base properties
	SchemaName = "lead_Appended_Third_Email",
	LogicalName = "lead_Appended_Third_Email",

	DisplayName = new Label("Appended Third Email", _languageCode),
	RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
	Description = new Label("Appended Third Email", _languageCode),
	MaxLength = 100,
	IsValidForForm = true,
    IsValidForGrid = true,
	Format = StringFormat.Email,
};
addedAttributes.Add(Appended_Third_Email);
#endregion Appended_Third_Email
