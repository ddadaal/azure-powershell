// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Properties of a project environment type.</summary>
    public partial class ProjectEnvironmentTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdateProperties __projectEnvironmentTypeUpdateProperties = new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ProjectEnvironmentTypeUpdateProperties();

        /// <summary>The role definition assigned to the environment creator on backing resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment CreatorRoleAssignment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).CreatorRoleAssignment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).CreatorRoleAssignment = value ?? null /* model class */; }

        /// <summary>A map of roles to assign to the environment creator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles CreatorRoleAssignmentRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).CreatorRoleAssignmentRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).CreatorRoleAssignmentRole = value ?? null /* model class */; }

        /// <summary>
        /// Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this
        /// subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string DeploymentTargetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).DeploymentTargetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).DeploymentTargetId = value ?? null; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the project environment type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EnvironmentCount" /> property.</summary>
        private int? _environmentCount;

        /// <summary>The number of environments of this type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public int? EnvironmentCount { get => this._environmentCount; }

        /// <summary>Internal Acessors for EnvironmentCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypePropertiesInternal.EnvironmentCount { get => this._environmentCount; set { {_environmentCount = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Defines whether this Environment Type can be used in this Project.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus)""); }

        /// <summary>
        /// Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role
        /// definition IDs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments UserRoleAssignment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).UserRoleAssignment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal)__projectEnvironmentTypeUpdateProperties).UserRoleAssignment = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="ProjectEnvironmentTypeProperties" /> instance.</summary>
        public ProjectEnvironmentTypeProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__projectEnvironmentTypeUpdateProperties), __projectEnvironmentTypeUpdateProperties);
            await eventListener.AssertObjectIsValid(nameof(__projectEnvironmentTypeUpdateProperties), __projectEnvironmentTypeUpdateProperties);
        }
    }
    /// Properties of a project environment type.
    public partial interface IProjectEnvironmentTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdateProperties
    {
        /// <summary>The display name of the project environment type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the project environment type.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The number of environments of this type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The number of environments of this type.",
        SerializedName = @"environmentCount",
        PossibleTypes = new [] { typeof(int) })]
        int? EnvironmentCount { get;  }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Properties of a project environment type.
    internal partial interface IProjectEnvironmentTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesInternal
    {
        /// <summary>The display name of the project environment type.</summary>
        string DisplayName { get; set; }
        /// <summary>The number of environments of this type.</summary>
        int? EnvironmentCount { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}