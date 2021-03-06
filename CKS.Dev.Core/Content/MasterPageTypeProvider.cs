using Microsoft.VisualStudio.SharePoint;
using System.ComponentModel.Composition;
using CKSProperties = CKS.Dev2015.Core.Properties.Resources;

namespace CKS.Dev2015.VisualStudio.SharePoint.Content
{
    /// <summary>
    /// MasterPage item provider.
    /// </summary>
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(ISharePointProjectItemTypeProvider))]
    // Specifies the ID for this new project item type. This string must match the value of the 
    // Type attribute of the ProjectItem element in the .spdata file for the project item.
    [SharePointProjectItemType(ProjectItemIds.MasterPage)]
    // Specifies the icon to display with this project item in Solution Explorer.
    [SharePointProjectItemIcon("CKS.Dev11.VisualStudio.SharePoint.Resources.SolutionExplorerIcons.MasterPage_SolutionExplorer.ico")]
    partial class MasterPageTypeProvider : ISharePointProjectItemTypeProvider
    {
        #region Methods

        /// <summary>
        /// Called by projects to initialize an instance of a SharePoint project item type.
        /// </summary>
        /// <param name="typeDefinition">A project item type definition to initialize.</param>
        public void InitializeType(ISharePointProjectItemTypeDefinition typeDefinition)
        {
            typeDefinition.Name = CKSProperties.MasterPageTypeProvider_TypeDefinitionName;
            typeDefinition.SupportedDeploymentScopes = SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            typeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;
            typeDefinition.SupportedAssemblyDeploymentTargets = SupportedAssemblyDeploymentTargets.All;
        }

        #endregion
    }
}