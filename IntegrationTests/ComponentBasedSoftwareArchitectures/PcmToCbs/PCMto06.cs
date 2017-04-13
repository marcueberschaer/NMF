//------------------------------------------------------------------------------
// <auto-generated>
//     This Code was automatically created by the Atl2NmfS higher-order transformation.
//
//     Changes to this file can result in a wrong behavior and are discarded if the code is generated again.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using global::System.Collections.Generic;
using System.Globalization;
using NMF.Expressions.Linq;
using NMF.Synchronizations;
using NMF.Transformations;
using NMF.Utilities;
using NMF.Models;

namespace NMFExamples.PcmToMM06
{
    public partial class PCMto06 : ReflectiveSynchronization
    {
        public PCMto06(InputModelContainer inputModelContainer, OutputModelContainer outputModelContainer)
        {
            InputModelContainer = inputModelContainer;
            OutputModelContainer = outputModelContainer;
        }
    	
    	public static InputModelContainer InputModelContainer { get; set; }
    	
    	public static OutputModelContainer OutputModelContainer { get; set; }

        public partial class Model2ModelMainRule : SynchronizationRule<InputModelContainer, OutputModelContainer>
        {
            public override bool ShouldCorrespond(InputModelContainer left, OutputModelContainer right, ISynchronizationContext context)
            {
                return true;
            }

            public override void DeclareSynchronization()
            {
                SynchronizeManyLeftToRightOnly(SyncRule<Allocation2Root>(),
                    input => input.Environment.Descendants().OfType<Pcm.Allocation.IAllocation>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Deployment.IAllocation>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Deployment.IAllocation>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Allocation2RootRoot>(),
                    input => input.Environment.Descendants().OfType<Pcm.Allocation.IAllocation>(),
                    output => new OutputModelCollection<ComponentBasedSystems.IRoot_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.IRoot_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Environment2Environment>(),
                    input => input.Environment.Descendants().OfType<Pcm.Resourceenvironment.IResourceEnvironment>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Deployment.IEnvironment_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Deployment.IEnvironment_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Container2Container>(),
                    input => input.Environment.Descendants().OfType<Pcm.Resourceenvironment.IResourceContainer>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Deployment.IContainer_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Deployment.IContainer_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Link2Link>(),
                    input => input.Environment.Descendants().OfType<Pcm.Resourceenvironment.ILinkingResource>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Deployment.ILink>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Deployment.ILink>()));

                SynchronizeManyLeftToRightOnly(SyncRule<AllocationContext2AllocationContext>(),
                    input => input.Environment.Descendants().OfType<Pcm.Allocation.IAllocationContext>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Deployment.IAllocationContext>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Deployment.IAllocationContext>()));

                SynchronizeManyLeftToRightOnly(SyncRule<System2System>(),
                    input => input.Environment.Descendants().OfType<Pcm.System.ISystem0>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Assembly.ISystem_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Assembly.ISystem_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Repository2Repository>(),
                    input => input.Environment.Descendants().OfType<Pcm.Repository.IRepository>(),
                    output => new OutputModelCollection<ComponentBasedSystems.SystemIndependent.IRepository_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.SystemIndependent.IRepository_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<AssemblyConnector2AssemblyConnector>(),
                    input => input.Environment.Descendants().OfType<Pcm.Core.Composition.IAssemblyConnector>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Assembly.IAssemblyConnector>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Assembly.IAssemblyConnector>()));

                SynchronizeManyLeftToRightOnly(SyncRule<ProvidingDelegationConnector2ProvidingDelegateConnector>(),
                    input => input.Environment.Descendants().OfType<Pcm.Core.Composition.IProvidedDelegationConnector>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Assembly.IProvidingDelegateConnector>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Assembly.IProvidingDelegateConnector>()));

                SynchronizeManyLeftToRightOnly(SyncRule<RequiringDelegationConnector2RequiringDelegateConnector>(),
                    input => input.Environment.Descendants().OfType<Pcm.Core.Composition.IRequiredDelegationConnector>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Assembly.IRequiringDelegateConnector>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Assembly.IRequiringDelegateConnector>()));

                SynchronizeManyLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
                    input => input.Environment.Descendants().OfType<Pcm.Core.Composition.IAssemblyContext>(),
                    output => new OutputModelCollection<ComponentBasedSystems.Assembly.IAssemblyContext>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.Assembly.IAssemblyContext>()));

                SynchronizeManyLeftToRightOnly(SyncRule<RepositoryComponent2Component>(),
                    input => input.Environment.Descendants().OfType<Pcm.Repository.IRepositoryComponent>(),
                    output => new OutputModelCollection<ComponentBasedSystems.SystemIndependent.IComponent_MM06>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.SystemIndependent.IComponent_MM06>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
                    input => input.Environment.Descendants().OfType<Pcm.Repository.IOperationInterface>(),
                    output => new OutputModelCollection<ComponentBasedSystems.SystemIndependent.IInterface>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.SystemIndependent.IInterface>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Signature2Signature>(),
                    input => input.Environment.Descendants().OfType<Pcm.Repository.IOperationSignature>(),
                    output => new OutputModelCollection<ComponentBasedSystems.SystemIndependent.ISignature>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.SystemIndependent.ISignature>()));

                SynchronizeManyLeftToRightOnly(SyncRule<Parameter2Parameter>(),
                    input => input.Environment.Descendants().OfType<Pcm.Repository.IParameter>(),
                    output => new OutputModelCollection<ComponentBasedSystems.SystemIndependent.IParameter>(output.OUT.RootElements.OfType<IModelElement, ComponentBasedSystems.SystemIndependent.IParameter>()));
            }
        }
    	
    	public partial class Allocation2Root : SynchronizationRule<Pcm.Allocation.IAllocation, ComponentBasedSystems.Deployment.IAllocation>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<System2System>(),
    	    		pcmAllocation => pcmAllocation.System_Allocation,
    	    		allocation => allocation.AllocatedSystem,
    	    		null);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<AllocationContext2AllocationContext>(),
    	    		pcmAllocation => pcmAllocation.AllocationContexts_Allocation,
    	    		allocation => allocation.Contexts);
    	    }
    	}
    	
    	public partial class Allocation2RootRoot : SynchronizationRule<Pcm.Allocation.IAllocation, ComponentBasedSystems.IRoot_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<Allocation2Root>(),
    	    		pcmAllocation => pcmAllocation,
    	    		root => root.Allocation,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<Repository2Repository>(),
    	    		(Pcm.Allocation.IAllocation pcmAllocation) => pcmAllocation.System_Allocation.AssemblyContexts__ComposedStructure.FirstOrDefault().EncapsulatedComponent__AssemblyContext.Repository__RepositoryComponent,
    	    		root => root.Repository,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<System2System>(),
    	    		pcmAllocation => pcmAllocation.System_Allocation,
    	    		root => root.System,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<Environment2Environment>(),
    	    		pcmAllocation => pcmAllocation.TargetResourceEnvironment_Allocation,
    	    		root => root.Environment,
    	    		null);
    	    }
    	}
    	
    	public partial class Environment2Environment : SynchronizationRule<Pcm.Resourceenvironment.IResourceEnvironment, ComponentBasedSystems.Deployment.IEnvironment_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Container2Container>(),
    	    		cmEnvironment => cmEnvironment.ResourceContainer_ResourceEnvironment,
    	    		environment => environment.Containers);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Link2Link>(),
    	    		cmEnvironment => cmEnvironment.LinkingResources__ResourceEnvironment,
    	    		environment => environment.Links);
    	    }
    	}
    	
    	public partial class Container2Container : SynchronizationRule<Pcm.Resourceenvironment.IResourceContainer, ComponentBasedSystems.Deployment.IContainer_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<Environment2Environment>(),
    	    		cmContainer => cmContainer.ResourceEnvironment_ResourceContainer,
    	    		container => container.Environment,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmContainer => cmContainer.EntityName,
    	    		container => container.Name);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Link2Link>(),
    	    		cmContainer => cmContainer.ResourceEnvironment_ResourceContainer.LinkingResources__ResourceEnvironment.Where(link => link.ConnectedResourceContainers_LinkingResource == cmContainer),
    	    		container => container.Links);
    	    }
    	}
    	
    	public partial class Link2Link : SynchronizationRule<Pcm.Resourceenvironment.ILinkingResource, ComponentBasedSystems.Deployment.ILink>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Container2Container>(),
    	    		cmLink => cmLink.ConnectedResourceContainers_LinkingResource,
    	    		link => link.ConnectedContainers);
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmLink => cmLink.EntityName,
    	    		link => link.Name);
    	    }
    	}
    	
    	public partial class AllocationContext2AllocationContext : SynchronizationRule<Pcm.Allocation.IAllocationContext, ComponentBasedSystems.Deployment.IAllocationContext>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmAllocationContext => cmAllocationContext.AssemblyContext_AllocationContext,
    	    		allocationContext => allocationContext.Assembly,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<Container2Container>(),
    	    		cmAllocationContext => cmAllocationContext.ResourceContainer_AllocationContext,
    	    		allocationContext => allocationContext.Container,
    	    		null);
    	    }
    	}
    	
    	public partial class System2System : SynchronizationRule<Pcm.System.ISystem0, ComponentBasedSystems.Assembly.ISystem_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeManyLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmSystem => cmSystem.AssemblyContexts__ComposedStructure,
    	    		system => system.EncapsulatedContexts);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmSystem => cmSystem.ProvidedRoles_InterfaceProvidingEntity.OfType<Pcm.Repository.IOperationProvidedRole>().Select(role => role.ProvidedInterface__OperationProvidedRole),
    	    		system => system.ProvidedInterfaces);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmSystem => cmSystem.RequiredRoles_InterfaceRequiringEntity.OfType<Pcm.Repository.IOperationRequiredRole>().Select(role => role.RequiredInterface__OperationRequiredRole),
    	    		system => system.RequiredInterfaces);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<AssemblyConnector2AssemblyConnector>(),
    	    		cmSystem => cmSystem.Connectors__ComposedStructure.OfType<Pcm.Core.Composition.IAssemblyConnector>(),
    	    		system => system.Connectors);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<ProvidingDelegationConnector2ProvidingDelegateConnector>(),
    	    		cmSystem => cmSystem.Connectors__ComposedStructure.OfType<Pcm.Core.Composition.IDelegationConnector>().OfType<Pcm.Core.Composition.IProvidedDelegationConnector>(),
    	    		system => system.DelegateConnectors.OfType<ComponentBasedSystems.Assembly.IDelegateConnector, ComponentBasedSystems.Assembly.IProvidingDelegateConnector>());
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<RequiringDelegationConnector2RequiringDelegateConnector>(),
    	    		cmSystem => cmSystem.Connectors__ComposedStructure.OfType<Pcm.Core.Composition.IDelegationConnector>().OfType<Pcm.Core.Composition.IRequiredDelegationConnector>(),
    	    		system => system.DelegateConnectors.OfType<ComponentBasedSystems.Assembly.IDelegateConnector, ComponentBasedSystems.Assembly.IRequiringDelegateConnector>());
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmSystem => cmSystem.EntityName,
    	    		system => system.Name);
    	    }
    	}
    	
    	public partial class Repository2Repository : SynchronizationRule<Pcm.Repository.IRepository, ComponentBasedSystems.SystemIndependent.IRepository_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeManyLeftToRightOnly(SyncRule<RepositoryComponent2Component>(),
    	    		cmRepository => cmRepository.Components__Repository,
    	    		repository => repository.Components);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Signature2Signature>(),
    	    		cmRepository => cmRepository.Interfaces__Repository.OfType<Pcm.Repository.IOperationInterface>().Select(opInterface => opInterface.Signatures__OperationInterface).SelectMany(x => x),
    	    		repository => repository.AvailableSignatures);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmRepository => cmRepository.Interfaces__Repository.OfType<Pcm.Repository.IOperationInterface>(),
    	    		repository => repository.Interfaces);
    	    }
    	}
    	
    	public partial class AssemblyConnector2AssemblyConnector : SynchronizationRule<Pcm.Core.Composition.IAssemblyConnector, ComponentBasedSystems.Assembly.IAssemblyConnector>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmAssemblyConnector => cmAssemblyConnector.ProvidedRole_AssemblyConnector.ProvidedInterface__OperationProvidedRole,
    	    		assemblyConnector => assemblyConnector.Interface,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmAssemblyConnector => cmAssemblyConnector.ProvidingAssemblyContext_AssemblyConnector,
    	    		assemblyConnector => assemblyConnector.ProvidingComponent,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmAssemblyConnector => cmAssemblyConnector.RequiringAssemblyContext_AssemblyConnector,
    	    		assemblyConnector => assemblyConnector.UsingComponent,
    	    		null);
    	    }
    	}
    	
    	public partial class ProvidingDelegationConnector2ProvidingDelegateConnector : SynchronizationRule<Pcm.Core.Composition.IProvidedDelegationConnector, ComponentBasedSystems.Assembly.IProvidingDelegateConnector>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmProvidedConnector => cmProvidedConnector.AssemblyContext_ProvidedDelegationConnector,
    	    		delegationConnector => delegationConnector.ConnectedAssemblyContext,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmProvidedConnector => cmProvidedConnector.InnerProvidedRole_ProvidedDelegationConnector.ProvidedInterface__OperationProvidedRole,
    	    		delegationConnector => delegationConnector.Interface,
    	    		null);
    	    }
    	}
    	
    	public partial class RequiringDelegationConnector2RequiringDelegateConnector : SynchronizationRule<Pcm.Core.Composition.IRequiredDelegationConnector, ComponentBasedSystems.Assembly.IRequiringDelegateConnector>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<AssemblyContext2AssemblyContext>(),
    	    		cmRequiringConnector => cmRequiringConnector.AssemblyContext_RequiredDelegationConnector,
    	    		delegationConnector => delegationConnector.ConnectedAssemblyContext,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmRequiringConnector => cmRequiringConnector.InnerRequiredRole_RequiredDelegationConnector.RequiredInterface__OperationRequiredRole,
    	    		delegationConnector => delegationConnector.Interface,
    	    		null);
    	    }
    	}
    	
    	public partial class AssemblyContext2AssemblyContext : SynchronizationRule<Pcm.Core.Composition.IAssemblyContext, ComponentBasedSystems.Assembly.IAssemblyContext>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(SyncRule<RepositoryComponent2Component>(),
    	    		cmAssemblyContext => cmAssemblyContext.EncapsulatedComponent__AssemblyContext,
    	    		assemblyContext => assemblyContext.Implements,
    	    		null);
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmAssemblyContext => cmAssemblyContext.EntityName,
    	    		assemblyContext => assemblyContext.Name);
    	    }
    	}
    	
    	public partial class RepositoryComponent2Component : SynchronizationRule<Pcm.Repository.IRepositoryComponent, ComponentBasedSystems.SystemIndependent.IComponent_MM06>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(
    	    		cmRepositoryComponent => cmRepositoryComponent.EntityName,
    	    		component => component.Name);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmRepositoryComponent => cmRepositoryComponent.ProvidedRoles_InterfaceProvidingEntity.OfType<Pcm.Repository.IOperationProvidedRole>().Select(role => role.ProvidedInterface__OperationProvidedRole),
    	    		component => component.ProvidedInterfaces);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Interface2Interface>(),
    	    		cmRepositoryComponent => cmRepositoryComponent.RequiredRoles_InterfaceRequiringEntity.OfType<Pcm.Repository.IOperationRequiredRole>().Select(role => role.RequiredInterface__OperationRequiredRole),
    	    		component => component.RequiredInterfaces);
    	    }
    	}
    	
    	public partial class Interface2Interface : SynchronizationRule<Pcm.Repository.IOperationInterface, ComponentBasedSystems.SystemIndependent.IInterface>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(
    	    		cmInterface => cmInterface.EntityName,
    	    		_interface => _interface.Name);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Signature2Signature>(),
    	    		cmInterface => cmInterface.Signatures__OperationInterface,
    	    		_interface => _interface.Signatures);
    	    }
    	}
    	
    	public partial class Signature2Signature : SynchronizationRule<Pcm.Repository.IOperationSignature, ComponentBasedSystems.SystemIndependent.ISignature>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(
    	    		cmSignature => cmSignature.EntityName,
    	    		signature => signature.Name);
    	    	
    	    	SynchronizeManyLeftToRightOnly(SyncRule<Parameter2Parameter>(),
    	    		cmSignature => cmSignature.Parameters__OperationSignature,
    	    		signature => signature.Parameter);
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmSignature => HelperExtensionMethods.ToDataType(cmSignature.ReturnType__OperationSignature),
    	    		signature => signature.ReturnType);
    	    }
    	}
    	
    	public partial class Parameter2Parameter : SynchronizationRule<Pcm.Repository.IParameter, ComponentBasedSystems.SystemIndependent.IParameter>
    	{
    	    public override void DeclareSynchronization()
    	    {
    	    	SynchronizeLeftToRightOnly(
    	    		cmParameter => cmParameter.ParameterName,
    	    		parameter => parameter.Name);
    	    	
    	    	SynchronizeLeftToRightOnly(
    	    		cmParameter => HelperExtensionMethods.ToDataType(cmParameter.DataType__Parameter),
    	    		parameter => parameter.Type);
    	    }
    	}
    }
}
