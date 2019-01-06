using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSignalSetting.Models
{
    // メモ: 生成されたコードは、少なくとも .NET Framework 4.5または .NET Core/Standard 2.0 が必要な可能性があります。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class configuration
    {

        private configurationConfigSections configSectionsField;

        private configurationUserSettings userSettingsField;

        /// <remarks/>
        public configurationConfigSections configSections
        {
            get
            {
                return this.configSectionsField;
            }
            set
            {
                this.configSectionsField = value;
            }
        }

        /// <remarks/>
        public configurationUserSettings userSettings
        {
            get
            {
                return this.userSettingsField;
            }
            set
            {
                this.userSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationConfigSections
    {

        private configurationConfigSectionsSectionGroup sectionGroupField;

        /// <remarks/>
        public configurationConfigSectionsSectionGroup sectionGroup
        {
            get
            {
                return this.sectionGroupField;
            }
            set
            {
                this.sectionGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationConfigSectionsSectionGroup
    {

        private configurationConfigSectionsSectionGroupSection sectionField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public configurationConfigSectionsSectionGroupSection section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationConfigSectionsSectionGroupSection
    {

        private string nameField;

        private string typeField;

        private string allowExeDefinitionField;

        private bool requirePermissionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string allowExeDefinition
        {
            get
            {
                return this.allowExeDefinitionField;
            }
            set
            {
                this.allowExeDefinitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool requirePermission
        {
            get
            {
                return this.requirePermissionField;
            }
            set
            {
                this.requirePermissionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationUserSettings
    {

        private configurationUserSettingsSetting[] timeSignalServiceTimeSignalSettingsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("TimeSignalService.TimeSignalSettings")]
        [System.Xml.Serialization.XmlArrayItemAttribute("setting", IsNullable = false)]
        public configurationUserSettingsSetting[] TimeSignalServiceTimeSignalSettings
        {
            get
            {
                return this.timeSignalServiceTimeSignalSettingsField;
            }
            set
            {
                this.timeSignalServiceTimeSignalSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationUserSettingsSetting
    {

        private string valueField;

        private string nameField;

        private string serializeAsField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serializeAs
        {
            get
            {
                return this.serializeAsField;
            }
            set
            {
                this.serializeAsField = value;
            }
        }
    }


}
