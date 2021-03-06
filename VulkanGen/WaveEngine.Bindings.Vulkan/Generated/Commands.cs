using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
{
	public static unsafe partial class VulkanNative
	{
		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateInstanceDelegate(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
		private static vkCreateInstanceDelegate vkCreateInstance_ptr;
		public static VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
			=> vkCreateInstance_ptr(pCreateInfo, pAllocator, pInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyInstanceDelegate(VkInstance instance, VkAllocationCallbacks* pAllocator);
		private static vkDestroyInstanceDelegate vkDestroyInstance_ptr;
		public static void vkDestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
			=> vkDestroyInstance_ptr(instance, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDevicesDelegate(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
		private static vkEnumeratePhysicalDevicesDelegate vkEnumeratePhysicalDevices_ptr;
		public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
			=> vkEnumeratePhysicalDevices_ptr(instance, pPhysicalDeviceCount, pPhysicalDevices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeaturesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);
		private static vkGetPhysicalDeviceFeaturesDelegate vkGetPhysicalDeviceFeatures_ptr;
		public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
			=> vkGetPhysicalDeviceFeatures_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);
		private static vkGetPhysicalDeviceFormatPropertiesDelegate vkGetPhysicalDeviceFormatProperties_ptr;
		public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatPropertiesDelegate vkGetPhysicalDeviceImageFormatProperties_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties_ptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDevicePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);
		private static vkGetPhysicalDevicePropertiesDelegate vkGetPhysicalDeviceProperties_ptr;
		public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
			=> vkGetPhysicalDeviceProperties_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate vkGetPhysicalDeviceQueueFamilyProperties_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryPropertiesDelegate vkGetPhysicalDeviceMemoryProperties_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr vkGetInstanceProcAddrDelegate(VkInstance instance, byte* pName);
		private static vkGetInstanceProcAddrDelegate vkGetInstanceProcAddr_ptr;
		public static IntPtr vkGetInstanceProcAddr(VkInstance instance, byte* pName)
			=> vkGetInstanceProcAddr_ptr(instance, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr vkGetDeviceProcAddrDelegate(VkDevice device, byte* pName);
		private static vkGetDeviceProcAddrDelegate vkGetDeviceProcAddr_ptr;
		public static IntPtr vkGetDeviceProcAddr(VkDevice device, byte* pName)
			=> vkGetDeviceProcAddr_ptr(device, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeviceDelegate(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice);
		private static vkCreateDeviceDelegate vkCreateDevice_ptr;
		public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
			=> vkCreateDevice_ptr(physicalDevice, pCreateInfo, pAllocator, pDevice);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeviceDelegate(VkDevice device, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDeviceDelegate vkDestroyDevice_ptr;
		public static void vkDestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDevice_ptr(device, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
		private static vkEnumerateInstanceExtensionPropertiesDelegate vkEnumerateInstanceExtensionProperties_ptr;
		public static VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
			=> vkEnumerateInstanceExtensionProperties_ptr(pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
		private static vkEnumerateDeviceExtensionPropertiesDelegate vkEnumerateDeviceExtensionProperties_ptr;
		public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
			=> vkEnumerateDeviceExtensionProperties_ptr(physicalDevice, pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate(uint* pPropertyCount, VkLayerProperties* pProperties);
		private static vkEnumerateInstanceLayerPropertiesDelegate vkEnumerateInstanceLayerProperties_ptr;
		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
			=> vkEnumerateInstanceLayerProperties_ptr(pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties);
		private static vkEnumerateDeviceLayerPropertiesDelegate vkEnumerateDeviceLayerProperties_ptr;
		public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
			=> vkEnumerateDeviceLayerProperties_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueueDelegate(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue);
		private static vkGetDeviceQueueDelegate vkGetDeviceQueue_ptr;
		public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
			=> vkGetDeviceQueue_ptr(device, queueFamilyIndex, queueIndex, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSubmitDelegate(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence);
		private static vkQueueSubmitDelegate vkQueueSubmit_ptr;
		public static VkResult vkQueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
			=> vkQueueSubmit_ptr(queue, submitCount, pSubmits, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueWaitIdleDelegate(VkQueue queue);
		private static vkQueueWaitIdleDelegate vkQueueWaitIdle_ptr;
		public static VkResult vkQueueWaitIdle(VkQueue queue)
			=> vkQueueWaitIdle_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDeviceWaitIdleDelegate(VkDevice device);
		private static vkDeviceWaitIdleDelegate vkDeviceWaitIdle_ptr;
		public static VkResult vkDeviceWaitIdle(VkDevice device)
			=> vkDeviceWaitIdle_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateMemoryDelegate(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);
		private static vkAllocateMemoryDelegate vkAllocateMemory_ptr;
		public static VkResult vkAllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
			=> vkAllocateMemory_ptr(device, pAllocateInfo, pAllocator, pMemory);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeMemoryDelegate(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator);
		private static vkFreeMemoryDelegate vkFreeMemory_ptr;
		public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
			=> vkFreeMemory_ptr(device, memory, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMapMemoryDelegate(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData);
		private static vkMapMemoryDelegate vkMapMemory_ptr;
		public static VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData)
			=> vkMapMemory_ptr(device, memory, offset, size, flags, ppData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUnmapMemoryDelegate(VkDevice device, VkDeviceMemory memory);
		private static vkUnmapMemoryDelegate vkUnmapMemory_ptr;
		public static void vkUnmapMemory(VkDevice device, VkDeviceMemory memory)
			=> vkUnmapMemory_ptr(device, memory);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkFlushMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
		private static vkFlushMappedMemoryRangesDelegate vkFlushMappedMemoryRanges_ptr;
		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
			=> vkFlushMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInvalidateMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
		private static vkInvalidateMappedMemoryRangesDelegate vkInvalidateMappedMemoryRanges_ptr;
		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
			=> vkInvalidateMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceMemoryCommitmentDelegate(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes);
		private static vkGetDeviceMemoryCommitmentDelegate vkGetDeviceMemoryCommitment_ptr;
		public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
			=> vkGetDeviceMemoryCommitment_ptr(device, memory, pCommittedMemoryInBytes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemoryDelegate(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindBufferMemoryDelegate vkBindBufferMemory_ptr;
		public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindBufferMemory_ptr(device, buffer, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemoryDelegate(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindImageMemoryDelegate vkBindImageMemory_ptr;
		public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindImageMemory_ptr(device, image, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirementsDelegate(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);
		private static vkGetBufferMemoryRequirementsDelegate vkGetBufferMemoryRequirements_ptr;
		public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
			=> vkGetBufferMemoryRequirements_ptr(device, buffer, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirementsDelegate(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);
		private static vkGetImageMemoryRequirementsDelegate vkGetImageMemoryRequirements_ptr;
		public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
			=> vkGetImageMemoryRequirements_ptr(device, image, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirementsDelegate(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirementsDelegate vkGetImageSparseMemoryRequirements_ptr;
		public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements_ptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate vkGetPhysicalDeviceSparseImageFormatProperties_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties_ptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueBindSparseDelegate(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
		private static vkQueueBindSparseDelegate vkQueueBindSparse_ptr;
		public static VkResult vkQueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
			=> vkQueueBindSparse_ptr(queue, bindInfoCount, pBindInfo, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFenceDelegate(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkCreateFenceDelegate vkCreateFence_ptr;
		public static VkResult vkCreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkCreateFence_ptr(device, pCreateInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFenceDelegate(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator);
		private static vkDestroyFenceDelegate vkDestroyFence_ptr;
		public static void vkDestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
			=> vkDestroyFence_ptr(device, fence, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences);
		private static vkResetFencesDelegate vkResetFences_ptr;
		public static VkResult vkResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
			=> vkResetFences_ptr(device, fenceCount, pFences);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceStatusDelegate(VkDevice device, VkFence fence);
		private static vkGetFenceStatusDelegate vkGetFenceStatus_ptr;
		public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence)
			=> vkGetFenceStatus_ptr(device, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitForFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout);
		private static vkWaitForFencesDelegate vkWaitForFences_ptr;
		public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout)
			=> vkWaitForFences_ptr(device, fenceCount, pFences, waitAll, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSemaphoreDelegate(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);
		private static vkCreateSemaphoreDelegate vkCreateSemaphore_ptr;
		public static VkResult vkCreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
			=> vkCreateSemaphore_ptr(device, pCreateInfo, pAllocator, pSemaphore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySemaphoreDelegate(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator);
		private static vkDestroySemaphoreDelegate vkDestroySemaphore_ptr;
		public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
			=> vkDestroySemaphore_ptr(device, semaphore, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateEventDelegate(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent);
		private static vkCreateEventDelegate vkCreateEvent_ptr;
		public static VkResult vkCreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
			=> vkCreateEvent_ptr(device, pCreateInfo, pAllocator, pEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyEventDelegate(VkDevice device, VkEvent vkEvent, VkAllocationCallbacks* pAllocator);
		private static vkDestroyEventDelegate vkDestroyEvent_ptr;
		public static void vkDestroyEvent(VkDevice device, VkEvent vkEvent, VkAllocationCallbacks* pAllocator)
			=> vkDestroyEvent_ptr(device, vkEvent, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetEventStatusDelegate(VkDevice device, VkEvent vkEvent);
		private static vkGetEventStatusDelegate vkGetEventStatus_ptr;
		public static VkResult vkGetEventStatus(VkDevice device, VkEvent vkEvent)
			=> vkGetEventStatus_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkSetEventDelegate vkSetEvent_ptr;
		public static VkResult vkSetEvent(VkDevice device, VkEvent vkEvent)
			=> vkSetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkResetEventDelegate vkResetEvent_ptr;
		public static VkResult vkResetEvent(VkDevice device, VkEvent vkEvent)
			=> vkResetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateQueryPoolDelegate(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);
		private static vkCreateQueryPoolDelegate vkCreateQueryPool_ptr;
		public static VkResult vkCreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
			=> vkCreateQueryPool_ptr(device, pCreateInfo, pAllocator, pQueryPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyQueryPoolDelegate vkDestroyQueryPool_ptr;
		public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyQueryPool_ptr(device, queryPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetQueryPoolResultsDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, VkQueryResultFlags flags);
		private static vkGetQueryPoolResultsDelegate vkGetQueryPoolResults_ptr;
		public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, VkQueryResultFlags flags)
			=> vkGetQueryPoolResults_ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferDelegate(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);
		private static vkCreateBufferDelegate vkCreateBuffer_ptr;
		public static VkResult vkCreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
			=> vkCreateBuffer_ptr(device, pCreateInfo, pAllocator, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferDelegate(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator);
		private static vkDestroyBufferDelegate vkDestroyBuffer_ptr;
		public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
			=> vkDestroyBuffer_ptr(device, buffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferViewDelegate(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView);
		private static vkCreateBufferViewDelegate vkCreateBufferView_ptr;
		public static VkResult vkCreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
			=> vkCreateBufferView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferViewDelegate(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator);
		private static vkDestroyBufferViewDelegate vkDestroyBufferView_ptr;
		public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
			=> vkDestroyBufferView_ptr(device, bufferView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageDelegate(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage);
		private static vkCreateImageDelegate vkCreateImage_ptr;
		public static VkResult vkCreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
			=> vkCreateImage_ptr(device, pCreateInfo, pAllocator, pImage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageDelegate(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator);
		private static vkDestroyImageDelegate vkDestroyImage_ptr;
		public static void vkDestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
			=> vkDestroyImage_ptr(device, image, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSubresourceLayoutDelegate(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);
		private static vkGetImageSubresourceLayoutDelegate vkGetImageSubresourceLayout_ptr;
		public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
			=> vkGetImageSubresourceLayout_ptr(device, image, pSubresource, pLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageViewDelegate(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView);
		private static vkCreateImageViewDelegate vkCreateImageView_ptr;
		public static VkResult vkCreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
			=> vkCreateImageView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageViewDelegate(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator);
		private static vkDestroyImageViewDelegate vkDestroyImageView_ptr;
		public static void vkDestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
			=> vkDestroyImageView_ptr(device, imageView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateShaderModuleDelegate(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);
		private static vkCreateShaderModuleDelegate vkCreateShaderModule_ptr;
		public static VkResult vkCreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
			=> vkCreateShaderModule_ptr(device, pCreateInfo, pAllocator, pShaderModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyShaderModuleDelegate(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator);
		private static vkDestroyShaderModuleDelegate vkDestroyShaderModule_ptr;
		public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
			=> vkDestroyShaderModule_ptr(device, shaderModule, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineCacheDelegate(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);
		private static vkCreatePipelineCacheDelegate vkCreatePipelineCache_ptr;
		public static VkResult vkCreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
			=> vkCreatePipelineCache_ptr(device, pCreateInfo, pAllocator, pPipelineCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineCacheDelegate(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineCacheDelegate vkDestroyPipelineCache_ptr;
		public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipelineCache_ptr(device, pipelineCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineCacheDataDelegate(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData);
		private static vkGetPipelineCacheDataDelegate vkGetPipelineCacheData_ptr;
		public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData)
			=> vkGetPipelineCacheData_ptr(device, pipelineCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergePipelineCachesDelegate(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches);
		private static vkMergePipelineCachesDelegate vkMergePipelineCaches_ptr;
		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
			=> vkMergePipelineCaches_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateGraphicsPipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateGraphicsPipelinesDelegate vkCreateGraphicsPipelines_ptr;
		public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateGraphicsPipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateComputePipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateComputePipelinesDelegate vkCreateComputePipelines_ptr;
		public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateComputePipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineDelegate(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineDelegate vkDestroyPipeline_ptr;
		public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipeline_ptr(device, pipeline, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineLayoutDelegate(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);
		private static vkCreatePipelineLayoutDelegate vkCreatePipelineLayout_ptr;
		public static VkResult vkCreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
			=> vkCreatePipelineLayout_ptr(device, pCreateInfo, pAllocator, pPipelineLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineLayoutDelegate(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineLayoutDelegate vkDestroyPipelineLayout_ptr;
		public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipelineLayout_ptr(device, pipelineLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerDelegate(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler);
		private static vkCreateSamplerDelegate vkCreateSampler_ptr;
		public static VkResult vkCreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
			=> vkCreateSampler_ptr(device, pCreateInfo, pAllocator, pSampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerDelegate(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator);
		private static vkDestroySamplerDelegate vkDestroySampler_ptr;
		public static void vkDestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
			=> vkDestroySampler_ptr(device, sampler, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);
		private static vkCreateDescriptorSetLayoutDelegate vkCreateDescriptorSetLayout_ptr;
		public static VkResult vkCreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
			=> vkCreateDescriptorSetLayout_ptr(device, pCreateInfo, pAllocator, pSetLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorSetLayoutDelegate vkDestroyDescriptorSetLayout_ptr;
		public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorSetLayout_ptr(device, descriptorSetLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorPoolDelegate(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);
		private static vkCreateDescriptorPoolDelegate vkCreateDescriptorPool_ptr;
		public static VkResult vkCreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
			=> vkCreateDescriptorPool_ptr(device, pCreateInfo, pAllocator, pDescriptorPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorPoolDelegate vkDestroyDescriptorPool_ptr;
		public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorPool_ptr(device, descriptorPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint flags);
		private static vkResetDescriptorPoolDelegate vkResetDescriptorPool_ptr;
		public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, uint flags)
			=> vkResetDescriptorPool_ptr(device, descriptorPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateDescriptorSetsDelegate(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);
		private static vkAllocateDescriptorSetsDelegate vkAllocateDescriptorSets_ptr;
		public static VkResult vkAllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
			=> vkAllocateDescriptorSets_ptr(device, pAllocateInfo, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkFreeDescriptorSetsDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets);
		private static vkFreeDescriptorSetsDelegate vkFreeDescriptorSets_ptr;
		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
			=> vkFreeDescriptorSets_ptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetsDelegate(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
		private static vkUpdateDescriptorSetsDelegate vkUpdateDescriptorSets_ptr;
		public static void vkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
			=> vkUpdateDescriptorSets_ptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFramebufferDelegate(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);
		private static vkCreateFramebufferDelegate vkCreateFramebuffer_ptr;
		public static VkResult vkCreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
			=> vkCreateFramebuffer_ptr(device, pCreateInfo, pAllocator, pFramebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFramebufferDelegate(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator);
		private static vkDestroyFramebufferDelegate vkDestroyFramebuffer_ptr;
		public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
			=> vkDestroyFramebuffer_ptr(device, framebuffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRenderPassDelegate(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
		private static vkCreateRenderPassDelegate vkCreateRenderPass_ptr;
		public static VkResult vkCreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
			=> vkCreateRenderPass_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyRenderPassDelegate(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator);
		private static vkDestroyRenderPassDelegate vkDestroyRenderPass_ptr;
		public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
			=> vkDestroyRenderPass_ptr(device, renderPass, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetRenderAreaGranularityDelegate(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);
		private static vkGetRenderAreaGranularityDelegate vkGetRenderAreaGranularity_ptr;
		public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
			=> vkGetRenderAreaGranularity_ptr(device, renderPass, pGranularity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCommandPoolDelegate(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);
		private static vkCreateCommandPoolDelegate vkCreateCommandPool_ptr;
		public static VkResult vkCreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
			=> vkCreateCommandPool_ptr(device, pCreateInfo, pAllocator, pCommandPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCommandPoolDelegate vkDestroyCommandPool_ptr;
		public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCommandPool_ptr(device, commandPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
		private static vkResetCommandPoolDelegate vkResetCommandPool_ptr;
		public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags)
			=> vkResetCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateCommandBuffersDelegate(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);
		private static vkAllocateCommandBuffersDelegate vkAllocateCommandBuffers_ptr;
		public static VkResult vkAllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
			=> vkAllocateCommandBuffers_ptr(device, pAllocateInfo, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeCommandBuffersDelegate(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
		private static vkFreeCommandBuffersDelegate vkFreeCommandBuffers_ptr;
		public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
			=> vkFreeCommandBuffers_ptr(device, commandPool, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBeginCommandBufferDelegate(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo);
		private static vkBeginCommandBufferDelegate vkBeginCommandBuffer_ptr;
		public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
			=> vkBeginCommandBuffer_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEndCommandBufferDelegate(VkCommandBuffer commandBuffer);
		private static vkEndCommandBufferDelegate vkEndCommandBuffer_ptr;
		public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer)
			=> vkEndCommandBuffer_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandBufferDelegate(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
		private static vkResetCommandBufferDelegate vkResetCommandBuffer_ptr;
		public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags)
			=> vkResetCommandBuffer_ptr(commandBuffer, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
		private static vkCmdBindPipelineDelegate vkCmdBindPipeline_ptr;
		public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
			=> vkCmdBindPipeline_ptr(commandBuffer, pipelineBindPoint, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports);
		private static vkCmdSetViewportDelegate vkCmdSetViewport_ptr;
		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
			=> vkCmdSetViewport_ptr(commandBuffer, firstViewport, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetScissorDelegate(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors);
		private static vkCmdSetScissorDelegate vkCmdSetScissor_ptr;
		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
			=> vkCmdSetScissor_ptr(commandBuffer, firstScissor, scissorCount, pScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineWidthDelegate(VkCommandBuffer commandBuffer, float lineWidth);
		private static vkCmdSetLineWidthDelegate vkCmdSetLineWidth_ptr;
		public static void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
			=> vkCmdSetLineWidth_ptr(commandBuffer, lineWidth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBiasDelegate(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		private static vkCmdSetDepthBiasDelegate vkCmdSetDepthBias_ptr;
		public static void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
			=> vkCmdSetDepthBias_ptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetBlendConstantsDelegate(VkCommandBuffer commandBuffer, float blendConstants);
		private static vkCmdSetBlendConstantsDelegate vkCmdSetBlendConstants_ptr;
		public static void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants)
			=> vkCmdSetBlendConstants_ptr(commandBuffer, blendConstants);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBoundsDelegate(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		private static vkCmdSetDepthBoundsDelegate vkCmdSetDepthBounds_ptr;
		public static void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
			=> vkCmdSetDepthBounds_ptr(commandBuffer, minDepthBounds, maxDepthBounds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilCompareMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
		private static vkCmdSetStencilCompareMaskDelegate vkCmdSetStencilCompareMask_ptr;
		public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask)
			=> vkCmdSetStencilCompareMask_ptr(commandBuffer, faceMask, compareMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilWriteMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
		private static vkCmdSetStencilWriteMaskDelegate vkCmdSetStencilWriteMask_ptr;
		public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask)
			=> vkCmdSetStencilWriteMask_ptr(commandBuffer, faceMask, writeMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilReferenceDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
		private static vkCmdSetStencilReferenceDelegate vkCmdSetStencilReference_ptr;
		public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference)
			=> vkCmdSetStencilReference_ptr(commandBuffer, faceMask, reference);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindDescriptorSetsDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		private static vkCmdBindDescriptorSetsDelegate vkCmdBindDescriptorSets_ptr;
		public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
			=> vkCmdBindDescriptorSets_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindIndexBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType);
		private static vkCmdBindIndexBufferDelegate vkCmdBindIndexBuffer_ptr;
		public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
			=> vkCmdBindIndexBuffer_ptr(commandBuffer, buffer, offset, indexType);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindVertexBuffersDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets);
		private static vkCmdBindVertexBuffersDelegate vkCmdBindVertexBuffers_ptr;
		public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
			=> vkCmdBindVertexBuffers_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawDelegate(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private static vkCmdDrawDelegate vkCmdDraw_ptr;
		public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
			=> vkCmdDraw_ptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedDelegate(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		private static vkCmdDrawIndexedDelegate vkCmdDrawIndexed_ptr;
		public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
			=> vkCmdDrawIndexed_ptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndirectDelegate vkCmdDrawIndirect_ptr;
		public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndexedIndirectDelegate vkCmdDrawIndexedIndirect_ptr;
		public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndexedIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchDelegate vkCmdDispatch_ptr;
		public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatch_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset);
		private static vkCmdDispatchIndirectDelegate vkCmdDispatchIndirect_ptr;
		public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
			=> vkCmdDispatchIndirect_ptr(commandBuffer, buffer, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions);
		private static vkCmdCopyBufferDelegate vkCmdCopyBuffer_ptr;
		public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
			=> vkCmdCopyBuffer_ptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions);
		private static vkCmdCopyImageDelegate vkCmdCopyImage_ptr;
		public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
			=> vkCmdCopyImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBlitImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter);
		private static vkCmdBlitImageDelegate vkCmdBlitImage_ptr;
		public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
			=> vkCmdBlitImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferToImageDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions);
		private static vkCmdCopyBufferToImageDelegate vkCmdCopyBufferToImage_ptr;
		public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
			=> vkCmdCopyBufferToImage_ptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageToBufferDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions);
		private static vkCmdCopyImageToBufferDelegate vkCmdCopyImageToBuffer_ptr;
		public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
			=> vkCmdCopyImageToBuffer_ptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdUpdateBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData);
		private static vkCmdUpdateBufferDelegate vkCmdUpdateBuffer_ptr;
		public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
			=> vkCmdUpdateBuffer_ptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdFillBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data);
		private static vkCmdFillBufferDelegate vkCmdFillBuffer_ptr;
		public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
			=> vkCmdFillBuffer_ptr(commandBuffer, dstBuffer, dstOffset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearColorImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges);
		private static vkCmdClearColorImageDelegate vkCmdClearColorImage_ptr;
		public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
			=> vkCmdClearColorImage_ptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearDepthStencilImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges);
		private static vkCmdClearDepthStencilImageDelegate vkCmdClearDepthStencilImage_ptr;
		public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
			=> vkCmdClearDepthStencilImage_ptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearAttachmentsDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects);
		private static vkCmdClearAttachmentsDelegate vkCmdClearAttachments_ptr;
		public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
			=> vkCmdClearAttachments_ptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResolveImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions);
		private static vkCmdResolveImageDelegate vkCmdResolveImage_ptr;
		public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
			=> vkCmdResolveImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask);
		private static vkCmdSetEventDelegate vkCmdSetEvent_ptr;
		public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask)
			=> vkCmdSetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask);
		private static vkCmdResetEventDelegate vkCmdResetEvent_ptr;
		public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask)
			=> vkCmdResetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWaitEventsDelegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
		private static vkCmdWaitEventsDelegate vkCmdWaitEvents_ptr;
		public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
			=> vkCmdWaitEvents_ptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPipelineBarrierDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
		private static vkCmdPipelineBarrierDelegate vkCmdPipelineBarrier_ptr;
		public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
			=> vkCmdPipelineBarrier_ptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
		private static vkCmdBeginQueryDelegate vkCmdBeginQuery_ptr;
		public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags)
			=> vkCmdBeginQuery_ptr(commandBuffer, queryPool, query, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
		private static vkCmdEndQueryDelegate vkCmdEndQuery_ptr;
		public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
			=> vkCmdEndQuery_ptr(commandBuffer, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetQueryPoolDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkCmdResetQueryPoolDelegate vkCmdResetQueryPool_ptr;
		public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkCmdResetQueryPool_ptr(commandBuffer, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteTimestampDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestampDelegate vkCmdWriteTimestamp_ptr;
		public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp_ptr(commandBuffer, pipelineStage, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyQueryPoolResultsDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags);
		private static vkCmdCopyQueryPoolResultsDelegate vkCmdCopyQueryPoolResults_ptr;
		public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags)
			=> vkCmdCopyQueryPoolResults_ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushConstantsDelegate(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
		private static vkCmdPushConstantsDelegate vkCmdPushConstants_ptr;
		public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
			=> vkCmdPushConstants_ptr(commandBuffer, layout, stageFlags, offset, size, pValues);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPassDelegate(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);
		private static vkCmdBeginRenderPassDelegate vkCmdBeginRenderPass_ptr;
		public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
			=> vkCmdBeginRenderPass_ptr(commandBuffer, pRenderPassBegin, contents);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdNextSubpassDelegate(VkCommandBuffer commandBuffer, VkSubpassContents contents);
		private static vkCmdNextSubpassDelegate vkCmdNextSubpass_ptr;
		public static void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
			=> vkCmdNextSubpass_ptr(commandBuffer, contents);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderPassDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndRenderPassDelegate vkCmdEndRenderPass_ptr;
		public static void vkCmdEndRenderPass(VkCommandBuffer commandBuffer)
			=> vkCmdEndRenderPass_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdExecuteCommandsDelegate(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
		private static vkCmdExecuteCommandsDelegate vkCmdExecuteCommands_ptr;
		public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
			=> vkCmdExecuteCommands_ptr(commandBuffer, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceVersionDelegate(uint* pApiVersion);
		private static vkEnumerateInstanceVersionDelegate vkEnumerateInstanceVersion_ptr;
		public static VkResult vkEnumerateInstanceVersion(uint* pApiVersion)
			=> vkEnumerateInstanceVersion_ptr(pApiVersion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
		private static vkBindBufferMemory2Delegate vkBindBufferMemory2_ptr;
		public static VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
			=> vkBindBufferMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
		private static vkBindImageMemory2Delegate vkBindImageMemory2_ptr;
		public static VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
			=> vkBindImageMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
		private static vkGetDeviceGroupPeerMemoryFeaturesDelegate vkGetDeviceGroupPeerMemoryFeatures_ptr;
		public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
			=> vkGetDeviceGroupPeerMemoryFeatures_ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDeviceMaskDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
		private static vkCmdSetDeviceMaskDelegate vkCmdSetDeviceMask_ptr;
		public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
			=> vkCmdSetDeviceMask_ptr(commandBuffer, deviceMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchBaseDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchBaseDelegate vkCmdDispatchBase_ptr;
		public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatchBase_ptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
		private static vkEnumeratePhysicalDeviceGroupsDelegate vkEnumeratePhysicalDeviceGroups_ptr;
		public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
			=> vkEnumeratePhysicalDeviceGroups_ptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirements2Delegate(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetImageMemoryRequirements2Delegate vkGetImageMemoryRequirements2_ptr;
		public static void vkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetImageMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirements2Delegate(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetBufferMemoryRequirements2Delegate vkGetBufferMemoryRequirements2_ptr;
		public static void vkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetBufferMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirements2Delegate(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirements2Delegate vkGetImageSparseMemoryRequirements2_ptr;
		public static void vkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements2_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeatures2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
		private static vkGetPhysicalDeviceFeatures2Delegate vkGetPhysicalDeviceFeatures2_ptr;
		public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
			=> vkGetPhysicalDeviceFeatures2_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
		private static vkGetPhysicalDeviceProperties2Delegate vkGetPhysicalDeviceProperties2_ptr;
		public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
			=> vkGetPhysicalDeviceProperties2_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
		private static vkGetPhysicalDeviceFormatProperties2Delegate vkGetPhysicalDeviceFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties2_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatProperties2Delegate vkGetPhysicalDeviceImageFormatProperties2_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties2_ptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyProperties2Delegate vkGetPhysicalDeviceQueueFamilyProperties2_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties2_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryProperties2Delegate vkGetPhysicalDeviceMemoryProperties2_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties2_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatProperties2Delegate vkGetPhysicalDeviceSparseImageFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties2_ptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkTrimCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkTrimCommandPoolDelegate vkTrimCommandPool_ptr;
		public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkTrimCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueue2Delegate(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue);
		private static vkGetDeviceQueue2Delegate vkGetDeviceQueue2_ptr;
		public static void vkGetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
			=> vkGetDeviceQueue2_ptr(device, pQueueInfo, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
		private static vkCreateSamplerYcbcrConversionDelegate vkCreateSamplerYcbcrConversion_ptr;
		public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
			=> vkCreateSamplerYcbcrConversion_ptr(device, pCreateInfo, pAllocator, pYcbcrConversion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
		private static vkDestroySamplerYcbcrConversionDelegate vkDestroySamplerYcbcrConversion_ptr;
		public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
			=> vkDestroySamplerYcbcrConversion_ptr(device, ycbcrConversion, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
		private static vkCreateDescriptorUpdateTemplateDelegate vkCreateDescriptorUpdateTemplate_ptr;
		public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
			=> vkCreateDescriptorUpdateTemplate_ptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorUpdateTemplateDelegate vkDestroyDescriptorUpdateTemplate_ptr;
		public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorUpdateTemplate_ptr(device, descriptorUpdateTemplate, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetWithTemplateDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
		private static vkUpdateDescriptorSetWithTemplateDelegate vkUpdateDescriptorSetWithTemplate_ptr;
		public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
			=> vkUpdateDescriptorSetWithTemplate_ptr(device, descriptorSet, descriptorUpdateTemplate, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
		private static vkGetPhysicalDeviceExternalBufferPropertiesDelegate vkGetPhysicalDeviceExternalBufferProperties_ptr;
		public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
			=> vkGetPhysicalDeviceExternalBufferProperties_ptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
		private static vkGetPhysicalDeviceExternalFencePropertiesDelegate vkGetPhysicalDeviceExternalFenceProperties_ptr;
		public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
			=> vkGetPhysicalDeviceExternalFenceProperties_ptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
		private static vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate vkGetPhysicalDeviceExternalSemaphoreProperties_ptr;
		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
			=> vkGetPhysicalDeviceExternalSemaphoreProperties_ptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutSupportDelegate(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
		private static vkGetDescriptorSetLayoutSupportDelegate vkGetDescriptorSetLayoutSupport_ptr;
		public static void vkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
			=> vkGetDescriptorSetLayoutSupport_ptr(device, pCreateInfo, pSupport);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndirectCountDelegate vkCmdDrawIndirectCount_ptr;
		public static void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndexedIndirectCountDelegate vkCmdDrawIndexedIndirectCount_ptr;
		public static void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndexedIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRenderPass2Delegate(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
		private static vkCreateRenderPass2Delegate vkCreateRenderPass2_ptr;
		public static VkResult vkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
			=> vkCreateRenderPass2_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPass2Delegate(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo);
		private static vkCmdBeginRenderPass2Delegate vkCmdBeginRenderPass2_ptr;
		public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
			=> vkCmdBeginRenderPass2_ptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdNextSubpass2Delegate(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo);
		private static vkCmdNextSubpass2Delegate vkCmdNextSubpass2_ptr;
		public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
			=> vkCmdNextSubpass2_ptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderPass2Delegate(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo);
		private static vkCmdEndRenderPass2Delegate vkCmdEndRenderPass2_ptr;
		public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
			=> vkCmdEndRenderPass2_ptr(commandBuffer, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkResetQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkResetQueryPoolDelegate vkResetQueryPool_ptr;
		public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkResetQueryPool_ptr(device, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreCounterValueDelegate(VkDevice device, VkSemaphore semaphore, ulong* pValue);
		private static vkGetSemaphoreCounterValueDelegate vkGetSemaphoreCounterValue_ptr;
		public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
			=> vkGetSemaphoreCounterValue_ptr(device, semaphore, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitSemaphoresDelegate(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout);
		private static vkWaitSemaphoresDelegate vkWaitSemaphores_ptr;
		public static VkResult vkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
			=> vkWaitSemaphores_ptr(device, pWaitInfo, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSignalSemaphoreDelegate(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo);
		private static vkSignalSemaphoreDelegate vkSignalSemaphore_ptr;
		public static VkResult vkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
			=> vkSignalSemaphore_ptr(device, pSignalInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferDeviceAddressDelegate(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
		private static vkGetBufferDeviceAddressDelegate vkGetBufferDeviceAddress_ptr;
		public static ulong vkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
			=> vkGetBufferDeviceAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferOpaqueCaptureAddressDelegate(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
		private static vkGetBufferOpaqueCaptureAddressDelegate vkGetBufferOpaqueCaptureAddress_ptr;
		public static ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
			=> vkGetBufferOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressDelegate(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);
		private static vkGetDeviceMemoryOpaqueCaptureAddressDelegate vkGetDeviceMemoryOpaqueCaptureAddress_ptr;
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
			=> vkGetDeviceMemoryOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySurfaceKHRDelegate(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator);
		private static vkDestroySurfaceKHRDelegate vkDestroySurfaceKHR_ptr;
		public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
			=> vkDestroySurfaceKHR_ptr(instance, surface, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);
		private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate vkGetPhysicalDeviceSurfaceSupportKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)
			=> vkGetPhysicalDeviceSurfaceSupportKHR_ptr(physicalDevice, queueFamilyIndex, surface, pSupported);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormatsKHR_ptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModesKHRDelegate vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModesKHR_ptr(physicalDevice, surface, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSwapchainKHRDelegate(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain);
		private static vkCreateSwapchainKHRDelegate vkCreateSwapchainKHR_ptr;
		public static VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
			=> vkCreateSwapchainKHR_ptr(device, pCreateInfo, pAllocator, pSwapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySwapchainKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator);
		private static vkDestroySwapchainKHRDelegate vkDestroySwapchainKHR_ptr;
		public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
			=> vkDestroySwapchainKHR_ptr(device, swapchain, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainImagesKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages);
		private static vkGetSwapchainImagesKHRDelegate vkGetSwapchainImagesKHR_ptr;
		public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
			=> vkGetSwapchainImagesKHR_ptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireNextImageKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
		private static vkAcquireNextImageKHRDelegate vkAcquireNextImageKHR_ptr;
		public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
			=> vkAcquireNextImageKHR_ptr(device, swapchain, timeout, semaphore, fence, pImageIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueuePresentKHRDelegate(VkQueue queue, VkPresentInfoKHR* pPresentInfo);
		private static vkQueuePresentKHRDelegate vkQueuePresentKHR_ptr;
		public static VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
			=> vkQueuePresentKHR_ptr(queue, pPresentInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays);
		private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
			=> vkGetDisplayPlaneSupportedDisplaysKHR_ptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
		private static vkGetDisplayModePropertiesKHRDelegate vkGetDisplayModePropertiesKHR_ptr;
		public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
			=> vkGetDisplayModePropertiesKHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayModeKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);
		private static vkCreateDisplayModeKHRDelegate vkCreateDisplayModeKHR_ptr;
		public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
			=> vkCreateDisplayModeKHR_ptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);
		private static vkGetDisplayPlaneCapabilitiesKHRDelegate vkGetDisplayPlaneCapabilitiesKHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
			=> vkGetDisplayPlaneCapabilitiesKHR_ptr(physicalDevice, mode, planeIndex, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateDisplayPlaneSurfaceKHRDelegate vkCreateDisplayPlaneSurfaceKHR_ptr;
		public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateDisplayPlaneSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSharedSwapchainsKHRDelegate(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);
		private static vkCreateSharedSwapchainsKHRDelegate vkCreateSharedSwapchainsKHR_ptr;
		public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
			=> vkCreateSharedSwapchainsKHR_ptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXlibSurfaceKHRDelegate(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateXlibSurfaceKHRDelegate vkCreateXlibSurfaceKHR_ptr;
		public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateXlibSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID);
		private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
			=> vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, dpy, visualID);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXcbSurfaceKHRDelegate(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateXcbSurfaceKHRDelegate vkCreateXcbSurfaceKHR_ptr;
		public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateXcbSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id);
		private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
			=> vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, connection, visual_id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWaylandSurfaceKHRDelegate(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateWaylandSurfaceKHRDelegate vkCreateWaylandSurfaceKHR_ptr;
		public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateWaylandSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
		private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
			=> vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAndroidSurfaceKHRDelegate(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateAndroidSurfaceKHRDelegate vkCreateAndroidSurfaceKHR_ptr;
		public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateAndroidSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWin32SurfaceKHRDelegate(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateWin32SurfaceKHRDelegate vkCreateWin32SurfaceKHR_ptr;
		public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateWin32SurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
		private static vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
			=> vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback);
		private static vkCreateDebugReportCallbackEXTDelegate vkCreateDebugReportCallbackEXT_ptr;
		public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
			=> vkCreateDebugReportCallbackEXT_ptr(instance, pCreateInfo, pAllocator, pCallback);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDebugReportCallbackEXTDelegate vkDestroyDebugReportCallbackEXT_ptr;
		public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDebugReportCallbackEXT_ptr(instance, callback, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDebugReportMessageEXTDelegate(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage);
		private static vkDebugReportMessageEXTDelegate vkDebugReportMessageEXT_ptr;
		public static void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
			=> vkDebugReportMessageEXT_ptr(instance, flags, objectType, vkObject, location, messageCode, pLayerPrefix, pMessage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo);
		private static vkDebugMarkerSetObjectTagEXTDelegate vkDebugMarkerSetObjectTagEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
			=> vkDebugMarkerSetObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo);
		private static vkDebugMarkerSetObjectNameEXTDelegate vkDebugMarkerSetObjectNameEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
			=> vkDebugMarkerSetObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerBeginEXTDelegate(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
		private static vkCmdDebugMarkerBeginEXTDelegate vkCmdDebugMarkerBeginEXT_ptr;
		public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
			=> vkCmdDebugMarkerBeginEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerEndEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdDebugMarkerEndEXTDelegate vkCmdDebugMarkerEndEXT_ptr;
		public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
			=> vkCmdDebugMarkerEndEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerInsertEXTDelegate(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
		private static vkCmdDebugMarkerInsertEXTDelegate vkCmdDebugMarkerInsertEXT_ptr;
		public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
			=> vkCmdDebugMarkerInsertEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceVideoCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkVideoProfileKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities);
		private static vkGetPhysicalDeviceVideoCapabilitiesKHRDelegate vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
			=> vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr(physicalDevice, pVideoProfile, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties);
		private static vkGetPhysicalDeviceVideoFormatPropertiesKHRDelegate vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
			=> vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateVideoSessionKHRDelegate(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession);
		private static vkCreateVideoSessionKHRDelegate vkCreateVideoSessionKHR_ptr;
		public static VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
			=> vkCreateVideoSessionKHR_ptr(device, pCreateInfo, pAllocator, pVideoSession);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyVideoSessionKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator);
		private static vkDestroyVideoSessionKHRDelegate vkDestroyVideoSessionKHR_ptr;
		public static void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
			=> vkDestroyVideoSessionKHR_ptr(device, videoSession, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetVideoSessionMemoryRequirementsKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, uint* pVideoSessionMemoryRequirementsCount, VkVideoGetMemoryPropertiesKHR* pVideoSessionMemoryRequirements);
		private static vkGetVideoSessionMemoryRequirementsKHRDelegate vkGetVideoSessionMemoryRequirementsKHR_ptr;
		public static VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pVideoSessionMemoryRequirementsCount, VkVideoGetMemoryPropertiesKHR* pVideoSessionMemoryRequirements)
			=> vkGetVideoSessionMemoryRequirementsKHR_ptr(device, videoSession, pVideoSessionMemoryRequirementsCount, pVideoSessionMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindVideoSessionMemoryKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, uint videoSessionBindMemoryCount, VkVideoBindMemoryKHR* pVideoSessionBindMemories);
		private static vkBindVideoSessionMemoryKHRDelegate vkBindVideoSessionMemoryKHR_ptr;
		public static VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint videoSessionBindMemoryCount, VkVideoBindMemoryKHR* pVideoSessionBindMemories)
			=> vkBindVideoSessionMemoryKHR_ptr(device, videoSession, videoSessionBindMemoryCount, pVideoSessionBindMemories);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters);
		private static vkCreateVideoSessionParametersKHRDelegate vkCreateVideoSessionParametersKHR_ptr;
		public static VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
			=> vkCreateVideoSessionParametersKHR_ptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkUpdateVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo);
		private static vkUpdateVideoSessionParametersKHRDelegate vkUpdateVideoSessionParametersKHR_ptr;
		public static VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
			=> vkUpdateVideoSessionParametersKHR_ptr(device, videoSessionParameters, pUpdateInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator);
		private static vkDestroyVideoSessionParametersKHRDelegate vkDestroyVideoSessionParametersKHR_ptr;
		public static void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
			=> vkDestroyVideoSessionParametersKHR_ptr(device, videoSessionParameters, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo);
		private static vkCmdBeginVideoCodingKHRDelegate vkCmdBeginVideoCodingKHR_ptr;
		public static void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
			=> vkCmdBeginVideoCodingKHR_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo);
		private static vkCmdEndVideoCodingKHRDelegate vkCmdEndVideoCodingKHR_ptr;
		public static void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
			=> vkCmdEndVideoCodingKHR_ptr(commandBuffer, pEndCodingInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdControlVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo);
		private static vkCmdControlVideoCodingKHRDelegate vkCmdControlVideoCodingKHR_ptr;
		public static void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
			=> vkCmdControlVideoCodingKHR_ptr(commandBuffer, pCodingControlInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDecodeVideoKHRDelegate(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pFrameInfo);
		private static vkCmdDecodeVideoKHRDelegate vkCmdDecodeVideoKHR_ptr;
		public static void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pFrameInfo)
			=> vkCmdDecodeVideoKHR_ptr(commandBuffer, pFrameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes);
		private static vkCmdBindTransformFeedbackBuffersEXTDelegate vkCmdBindTransformFeedbackBuffersEXT_ptr;
		public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
			=> vkCmdBindTransformFeedbackBuffersEXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets);
		private static vkCmdBeginTransformFeedbackEXTDelegate vkCmdBeginTransformFeedbackEXT_ptr;
		public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
			=> vkCmdBeginTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets);
		private static vkCmdEndTransformFeedbackEXTDelegate vkCmdEndTransformFeedbackEXT_ptr;
		public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
			=> vkCmdEndTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
		private static vkCmdBeginQueryIndexedEXTDelegate vkCmdBeginQueryIndexedEXT_ptr;
		public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
			=> vkCmdBeginQueryIndexedEXT_ptr(commandBuffer, queryPool, query, flags, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
		private static vkCmdEndQueryIndexedEXTDelegate vkCmdEndQueryIndexedEXT_ptr;
		public static void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
			=> vkCmdEndQueryIndexedEXT_ptr(commandBuffer, queryPool, query, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectByteCountEXTDelegate(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride);
		private static vkCmdDrawIndirectByteCountEXTDelegate vkCmdDrawIndirectByteCountEXT_ptr;
		public static void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
			=> vkCmdDrawIndirectByteCountEXT_ptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCuModuleNVXDelegate(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule);
		private static vkCreateCuModuleNVXDelegate vkCreateCuModuleNVX_ptr;
		public static VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
			=> vkCreateCuModuleNVX_ptr(device, pCreateInfo, pAllocator, pModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCuFunctionNVXDelegate(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction);
		private static vkCreateCuFunctionNVXDelegate vkCreateCuFunctionNVX_ptr;
		public static VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
			=> vkCreateCuFunctionNVX_ptr(device, pCreateInfo, pAllocator, pFunction);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCuModuleNVXDelegate(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCuModuleNVXDelegate vkDestroyCuModuleNVX_ptr;
		public static void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCuModuleNVX_ptr(device, module, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCuFunctionNVXDelegate(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCuFunctionNVXDelegate vkDestroyCuFunctionNVX_ptr;
		public static void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCuFunctionNVX_ptr(device, function, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCuLaunchKernelNVXDelegate(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo);
		private static vkCmdCuLaunchKernelNVXDelegate vkCmdCuLaunchKernelNVX_ptr;
		public static void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
			=> vkCmdCuLaunchKernelNVX_ptr(commandBuffer, pLaunchInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetImageViewHandleNVXDelegate(VkDevice device, VkImageViewHandleInfoNVX* pInfo);
		private static vkGetImageViewHandleNVXDelegate vkGetImageViewHandleNVX_ptr;
		public static uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
			=> vkGetImageViewHandleNVX_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageViewAddressNVXDelegate(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties);
		private static vkGetImageViewAddressNVXDelegate vkGetImageViewAddressNVX_ptr;
		public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
			=> vkGetImageViewAddressNVX_ptr(device, imageView, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetShaderInfoAMDDelegate(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo);
		private static vkGetShaderInfoAMDDelegate vkGetShaderInfoAMD_ptr;
		public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
			=> vkGetShaderInfoAMD_ptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateStreamDescriptorSurfaceGGPDelegate(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateStreamDescriptorSurfaceGGPDelegate vkCreateStreamDescriptorSurfaceGGP_ptr;
		public static VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateStreamDescriptorSurfaceGGP_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
		private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
			=> vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleNVDelegate(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle);
		private static vkGetMemoryWin32HandleNVDelegate vkGetMemoryWin32HandleNV_ptr;
		public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle)
			=> vkGetMemoryWin32HandleNV_ptr(device, memory, handleType, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateViSurfaceNNDelegate(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateViSurfaceNNDelegate vkCreateViSurfaceNN_ptr;
		public static VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateViSurfaceNN_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleKHRDelegate(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetMemoryWin32HandleKHRDelegate vkGetMemoryWin32HandleKHR_ptr;
		public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetMemoryWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
		private static vkGetMemoryWin32HandlePropertiesKHRDelegate vkGetMemoryWin32HandlePropertiesKHR_ptr;
		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
			=> vkGetMemoryWin32HandlePropertiesKHR_ptr(device, handleType, handle, pMemoryWin32HandleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdKHRDelegate(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetMemoryFdKHRDelegate vkGetMemoryFdKHR_ptr;
		public static VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetMemoryFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);
		private static vkGetMemoryFdPropertiesKHRDelegate vkGetMemoryFdPropertiesKHR_ptr;
		public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
			=> vkGetMemoryFdPropertiesKHR_ptr(device, handleType, fd, pMemoryFdProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
		private static vkImportSemaphoreWin32HandleKHRDelegate vkImportSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
			=> vkImportSemaphoreWin32HandleKHR_ptr(device, pImportSemaphoreWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetSemaphoreWin32HandleKHRDelegate vkGetSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetSemaphoreWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreFdKHRDelegate(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);
		private static vkImportSemaphoreFdKHRDelegate vkImportSemaphoreFdKHR_ptr;
		public static VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
			=> vkImportSemaphoreFdKHR_ptr(device, pImportSemaphoreFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreFdKHRDelegate(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetSemaphoreFdKHRDelegate vkGetSemaphoreFdKHR_ptr;
		public static VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetSemaphoreFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushDescriptorSetKHRDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
		private static vkCmdPushDescriptorSetKHRDelegate vkCmdPushDescriptorSetKHR_ptr;
		public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
			=> vkCmdPushDescriptorSetKHR_ptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);
		private static vkCmdBeginConditionalRenderingEXTDelegate vkCmdBeginConditionalRenderingEXT_ptr;
		public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
			=> vkCmdBeginConditionalRenderingEXT_ptr(commandBuffer, pConditionalRenderingBegin);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndConditionalRenderingEXTDelegate vkCmdEndConditionalRenderingEXT_ptr;
		public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndConditionalRenderingEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWScalingNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings);
		private static vkCmdSetViewportWScalingNVDelegate vkCmdSetViewportWScalingNV_ptr;
		public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
			=> vkCmdSetViewportWScalingNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleaseDisplayEXTDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private static vkReleaseDisplayEXTDelegate vkReleaseDisplayEXT_ptr;
		public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
			=> vkReleaseDisplayEXT_ptr(physicalDevice, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireXlibDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display);
		private static vkAcquireXlibDisplayEXTDelegate vkAcquireXlibDisplayEXT_ptr;
		public static VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
			=> vkAcquireXlibDisplayEXT_ptr(physicalDevice, dpy, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRandROutputDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay);
		private static vkGetRandROutputDisplayEXTDelegate vkGetRandROutputDisplayEXT_ptr;
		public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
			=> vkGetRandROutputDisplayEXT_ptr(physicalDevice, dpy, rrOutput, pDisplay);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDisplayPowerControlEXTDelegate(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo);
		private static vkDisplayPowerControlEXTDelegate vkDisplayPowerControlEXT_ptr;
		public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
			=> vkDisplayPowerControlEXT_ptr(device, display, pDisplayPowerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDeviceEventEXTDelegate(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkRegisterDeviceEventEXTDelegate vkRegisterDeviceEventEXT_ptr;
		public static VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkRegisterDeviceEventEXT_ptr(device, pDeviceEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDisplayEventEXTDelegate(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkRegisterDisplayEventEXTDelegate vkRegisterDisplayEventEXT_ptr;
		public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkRegisterDisplayEventEXT_ptr(device, display, pDisplayEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainCounterEXTDelegate(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue);
		private static vkGetSwapchainCounterEXTDelegate vkGetSwapchainCounterEXT_ptr;
		public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
			=> vkGetSwapchainCounterEXT_ptr(device, swapchain, counter, pCounterValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
		private static vkGetRefreshCycleDurationGOOGLEDelegate vkGetRefreshCycleDurationGOOGLE_ptr;
		public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
			=> vkGetRefreshCycleDurationGOOGLE_ptr(device, swapchain, pDisplayTimingProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
		private static vkGetPastPresentationTimingGOOGLEDelegate vkGetPastPresentationTimingGOOGLE_ptr;
		public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
			=> vkGetPastPresentationTimingGOOGLE_ptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDiscardRectangleEXTDelegate(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles);
		private static vkCmdSetDiscardRectangleEXTDelegate vkCmdSetDiscardRectangleEXT_ptr;
		public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
			=> vkCmdSetDiscardRectangleEXT_ptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetHdrMetadataEXTDelegate(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata);
		private static vkSetHdrMetadataEXTDelegate vkSetHdrMetadataEXT_ptr;
		public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
			=> vkSetHdrMetadataEXT_ptr(device, swapchainCount, pSwapchains, pMetadata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainStatusKHRDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkGetSwapchainStatusKHRDelegate vkGetSwapchainStatusKHR_ptr;
		public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
			=> vkGetSwapchainStatusKHR_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceWin32HandleKHRDelegate(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
		private static vkImportFenceWin32HandleKHRDelegate vkImportFenceWin32HandleKHR_ptr;
		public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
			=> vkImportFenceWin32HandleKHR_ptr(device, pImportFenceWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceWin32HandleKHRDelegate(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetFenceWin32HandleKHRDelegate vkGetFenceWin32HandleKHR_ptr;
		public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetFenceWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceFdKHRDelegate(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo);
		private static vkImportFenceFdKHRDelegate vkImportFenceFdKHR_ptr;
		public static VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
			=> vkImportFenceFdKHR_ptr(device, pImportFenceFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceFdKHRDelegate(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetFenceFdKHRDelegate vkGetFenceFdKHR_ptr;
		public static VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetFenceFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions);
		private static vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
			=> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses);
		private static vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
			=> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireProfilingLockKHRDelegate(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo);
		private static vkAcquireProfilingLockKHRDelegate vkAcquireProfilingLockKHR_ptr;
		public static VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
			=> vkAcquireProfilingLockKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkReleaseProfilingLockKHRDelegate(VkDevice device);
		private static vkReleaseProfilingLockKHRDelegate vkReleaseProfilingLockKHR_ptr;
		public static void vkReleaseProfilingLockKHR(VkDevice device)
			=> vkReleaseProfilingLockKHR_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormats2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties);
		private static vkGetPhysicalDeviceDisplayProperties2KHRDelegate vkGetPhysicalDeviceDisplayProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
			=> vkGetPhysicalDeviceDisplayProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModeProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);
		private static vkGetDisplayModeProperties2KHRDelegate vkGetDisplayModeProperties2KHR_ptr;
		public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
			=> vkGetDisplayModeProperties2KHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);
		private static vkGetDisplayPlaneCapabilities2KHRDelegate vkGetDisplayPlaneCapabilities2KHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
			=> vkGetDisplayPlaneCapabilities2KHR_ptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIOSSurfaceMVKDelegate(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateIOSSurfaceMVKDelegate vkCreateIOSSurfaceMVK_ptr;
		public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateIOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMacOSSurfaceMVKDelegate(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateMacOSSurfaceMVKDelegate vkCreateMacOSSurfaceMVK_ptr;
		public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateMacOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo);
		private static vkSetDebugUtilsObjectNameEXTDelegate vkSetDebugUtilsObjectNameEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
			=> vkSetDebugUtilsObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo);
		private static vkSetDebugUtilsObjectTagEXTDelegate vkSetDebugUtilsObjectTagEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
			=> vkSetDebugUtilsObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueBeginDebugUtilsLabelEXTDelegate(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkQueueBeginDebugUtilsLabelEXTDelegate vkQueueBeginDebugUtilsLabelEXT_ptr;
		public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkQueueBeginDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueEndDebugUtilsLabelEXTDelegate(VkQueue queue);
		private static vkQueueEndDebugUtilsLabelEXTDelegate vkQueueEndDebugUtilsLabelEXT_ptr;
		public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
			=> vkQueueEndDebugUtilsLabelEXT_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueInsertDebugUtilsLabelEXTDelegate(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkQueueInsertDebugUtilsLabelEXTDelegate vkQueueInsertDebugUtilsLabelEXT_ptr;
		public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkQueueInsertDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkCmdBeginDebugUtilsLabelEXTDelegate vkCmdBeginDebugUtilsLabelEXT_ptr;
		public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkCmdBeginDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndDebugUtilsLabelEXTDelegate vkCmdEndDebugUtilsLabelEXT_ptr;
		public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndDebugUtilsLabelEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdInsertDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkCmdInsertDebugUtilsLabelEXTDelegate vkCmdInsertDebugUtilsLabelEXT_ptr;
		public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkCmdInsertDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger);
		private static vkCreateDebugUtilsMessengerEXTDelegate vkCreateDebugUtilsMessengerEXT_ptr;
		public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
			=> vkCreateDebugUtilsMessengerEXT_ptr(instance, pCreateInfo, pAllocator, pMessenger);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDebugUtilsMessengerEXTDelegate vkDestroyDebugUtilsMessengerEXT_ptr;
		public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDebugUtilsMessengerEXT_ptr(instance, messenger, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSubmitDebugUtilsMessageEXTDelegate(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
		private static vkSubmitDebugUtilsMessageEXTDelegate vkSubmitDebugUtilsMessageEXT_ptr;
		public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
			=> vkSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, pCallbackData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAndroidHardwareBufferPropertiesANDROIDDelegate(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties);
		private static vkGetAndroidHardwareBufferPropertiesANDROIDDelegate vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
		public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
			=> vkGetAndroidHardwareBufferPropertiesANDROID_ptr(device, buffer, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryAndroidHardwareBufferANDROIDDelegate(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr pBuffer);
		private static vkGetMemoryAndroidHardwareBufferANDROIDDelegate vkGetMemoryAndroidHardwareBufferANDROID_ptr;
		public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr pBuffer)
			=> vkGetMemoryAndroidHardwareBufferANDROID_ptr(device, pInfo, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetSampleLocationsEXTDelegate(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo);
		private static vkCmdSetSampleLocationsEXTDelegate vkCmdSetSampleLocationsEXT_ptr;
		public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
			=> vkCmdSetSampleLocationsEXT_ptr(commandBuffer, pSampleLocationsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties);
		private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;
		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
			=> vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr(physicalDevice, samples, pMultisampleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure);
		private static vkCreateAccelerationStructureKHRDelegate vkCreateAccelerationStructureKHR_ptr;
		public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
			=> vkCreateAccelerationStructureKHR_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator);
		private static vkDestroyAccelerationStructureKHRDelegate vkDestroyAccelerationStructureKHR_ptr;
		public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
			=> vkDestroyAccelerationStructureKHR_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructuresKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
		private static vkCmdBuildAccelerationStructuresKHRDelegate vkCmdBuildAccelerationStructuresKHR_ptr;
		public static void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
			=> vkCmdBuildAccelerationStructuresKHR_ptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructuresIndirectKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts);
		private static vkCmdBuildAccelerationStructuresIndirectKHRDelegate vkCmdBuildAccelerationStructuresIndirectKHR_ptr;
		public static void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
			=> vkCmdBuildAccelerationStructuresIndirectKHR_ptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBuildAccelerationStructuresKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
		private static vkBuildAccelerationStructuresKHRDelegate vkBuildAccelerationStructuresKHR_ptr;
		public static VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
			=> vkBuildAccelerationStructuresKHR_ptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo);
		private static vkCopyAccelerationStructureKHRDelegate vkCopyAccelerationStructureKHR_ptr;
		public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
			=> vkCopyAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
		private static vkCopyAccelerationStructureToMemoryKHRDelegate vkCopyAccelerationStructureToMemoryKHR_ptr;
		public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
			=> vkCopyAccelerationStructureToMemoryKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
		private static vkCopyMemoryToAccelerationStructureKHRDelegate vkCopyMemoryToAccelerationStructureKHR_ptr;
		public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
			=> vkCopyMemoryToAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride);
		private static vkWriteAccelerationStructuresPropertiesKHRDelegate vkWriteAccelerationStructuresPropertiesKHR_ptr;
		public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
			=> vkWriteAccelerationStructuresPropertiesKHR_ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo);
		private static vkCmdCopyAccelerationStructureKHRDelegate vkCmdCopyAccelerationStructureKHR_ptr;
		public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
			=> vkCmdCopyAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
		private static vkCmdCopyAccelerationStructureToMemoryKHRDelegate vkCmdCopyAccelerationStructureToMemoryKHR_ptr;
		public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
			=> vkCmdCopyAccelerationStructureToMemoryKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
		private static vkCmdCopyMemoryToAccelerationStructureKHRDelegate vkCmdCopyMemoryToAccelerationStructureKHR_ptr;
		public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
			=> vkCmdCopyMemoryToAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetAccelerationStructureDeviceAddressKHRDelegate(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo);
		private static vkGetAccelerationStructureDeviceAddressKHRDelegate vkGetAccelerationStructureDeviceAddressKHR_ptr;
		public static ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
			=> vkGetAccelerationStructureDeviceAddressKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesKHRDelegate vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesKHR_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceAccelerationStructureCompatibilityKHRDelegate(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility);
		private static vkGetDeviceAccelerationStructureCompatibilityKHRDelegate vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;
		public static void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
			=> vkGetDeviceAccelerationStructureCompatibilityKHR_ptr(device, pVersionInfo, pCompatibility);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureBuildSizesKHRDelegate(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo);
		private static vkGetAccelerationStructureBuildSizesKHRDelegate vkGetAccelerationStructureBuildSizesKHR_ptr;
		public static void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
			=> vkGetAccelerationStructureBuildSizesKHR_ptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysKHRDelegate(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth);
		private static vkCmdTraceRaysKHRDelegate vkCmdTraceRaysKHR_ptr;
		public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
			=> vkCmdTraceRaysKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateRayTracingPipelinesKHRDelegate vkCreateRayTracingPipelinesKHR_ptr;
		public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateRayTracingPipelinesKHR_ptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRayTracingShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingShaderGroupHandlesKHRDelegate vkGetRayTracingShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysIndirectKHRDelegate(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress);
		private static vkCmdTraceRaysIndirectKHRDelegate vkCmdTraceRaysIndirectKHR_ptr;
		public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
			=> vkCmdTraceRaysIndirectKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetRayTracingShaderGroupStackSizeKHRDelegate(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader);
		private static vkGetRayTracingShaderGroupStackSizeKHRDelegate vkGetRayTracingShaderGroupStackSizeKHR_ptr;
		public static ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
			=> vkGetRayTracingShaderGroupStackSizeKHR_ptr(device, pipeline, group, groupShader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRayTracingPipelineStackSizeKHRDelegate(VkCommandBuffer commandBuffer, uint pipelineStackSize);
		private static vkCmdSetRayTracingPipelineStackSizeKHRDelegate vkCmdSetRayTracingPipelineStackSizeKHR_ptr;
		public static void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
			=> vkCmdSetRayTracingPipelineStackSizeKHR_ptr(commandBuffer, pipelineStackSize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties);
		private static vkGetImageDrmFormatModifierPropertiesEXTDelegate vkGetImageDrmFormatModifierPropertiesEXT_ptr;
		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
			=> vkGetImageDrmFormatModifierPropertiesEXT_ptr(device, image, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateValidationCacheEXTDelegate(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);
		private static vkCreateValidationCacheEXTDelegate vkCreateValidationCacheEXT_ptr;
		public static VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
			=> vkCreateValidationCacheEXT_ptr(device, pCreateInfo, pAllocator, pValidationCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyValidationCacheEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator);
		private static vkDestroyValidationCacheEXTDelegate vkDestroyValidationCacheEXT_ptr;
		public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
			=> vkDestroyValidationCacheEXT_ptr(device, validationCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergeValidationCachesEXTDelegate(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches);
		private static vkMergeValidationCachesEXTDelegate vkMergeValidationCachesEXT_ptr;
		public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
			=> vkMergeValidationCachesEXT_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetValidationCacheDataEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData);
		private static vkGetValidationCacheDataEXTDelegate vkGetValidationCacheDataEXT_ptr;
		public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
			=> vkGetValidationCacheDataEXT_ptr(device, validationCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindShadingRateImageNVDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private static vkCmdBindShadingRateImageNVDelegate vkCmdBindShadingRateImageNV_ptr;
		public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
			=> vkCmdBindShadingRateImageNV_ptr(commandBuffer, imageView, imageLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportShadingRatePaletteNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes);
		private static vkCmdSetViewportShadingRatePaletteNVDelegate vkCmdSetViewportShadingRatePaletteNV_ptr;
		public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
			=> vkCmdSetViewportShadingRatePaletteNV_ptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoarseSampleOrderNVDelegate(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
		private static vkCmdSetCoarseSampleOrderNVDelegate vkCmdSetCoarseSampleOrderNV_ptr;
		public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
			=> vkCmdSetCoarseSampleOrderNV_ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureNVDelegate(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure);
		private static vkCreateAccelerationStructureNVDelegate vkCreateAccelerationStructureNV_ptr;
		public static VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
			=> vkCreateAccelerationStructureNV_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyAccelerationStructureNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator);
		private static vkDestroyAccelerationStructureNVDelegate vkDestroyAccelerationStructureNV_ptr;
		public static void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
			=> vkDestroyAccelerationStructureNV_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsNVDelegate vkGetAccelerationStructureMemoryRequirementsNV_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindAccelerationStructureMemoryNVDelegate(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
		private static vkBindAccelerationStructureMemoryNVDelegate vkBindAccelerationStructureMemoryNV_ptr;
		public static VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
			=> vkBindAccelerationStructureMemoryNV_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset);
		private static vkCmdBuildAccelerationStructureNVDelegate vkCmdBuildAccelerationStructureNV_ptr;
		public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
			=> vkCmdBuildAccelerationStructureNV_ptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode);
		private static vkCmdCopyAccelerationStructureNVDelegate vkCmdCopyAccelerationStructureNV_ptr;
		public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
			=> vkCmdCopyAccelerationStructureNV_ptr(commandBuffer, dst, src, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysNVDelegate(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
		private static vkCmdTraceRaysNVDelegate vkCmdTraceRaysNV_ptr;
		public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
			=> vkCmdTraceRaysNV_ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesNVDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateRayTracingPipelinesNVDelegate vkCreateRayTracingPipelinesNV_ptr;
		public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateRayTracingPipelinesNV_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAccelerationStructureHandleNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData);
		private static vkGetAccelerationStructureHandleNVDelegate vkGetAccelerationStructureHandleNV_ptr;
		public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData)
			=> vkGetAccelerationStructureHandleNV_ptr(device, accelerationStructure, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesNVDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesNVDelegate vkCmdWriteAccelerationStructuresPropertiesNV_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesNV_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCompileDeferredNVDelegate(VkDevice device, VkPipeline pipeline, uint shader);
		private static vkCompileDeferredNVDelegate vkCompileDeferredNV_ptr;
		public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
			=> vkCompileDeferredNV_ptr(device, pipeline, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
		private static vkGetMemoryHostPointerPropertiesEXTDelegate vkGetMemoryHostPointerPropertiesEXT_ptr;
		public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
			=> vkGetMemoryHostPointerPropertiesEXT_ptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteBufferMarkerAMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
		private static vkCmdWriteBufferMarkerAMDDelegate vkCmdWriteBufferMarkerAMD_ptr;
		public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
			=> vkCmdWriteBufferMarkerAMD_ptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
		private static vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;
		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
			=> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr(physicalDevice, pTimeDomainCount, pTimeDomains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetCalibratedTimestampsEXTDelegate(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
		private static vkGetCalibratedTimestampsEXTDelegate vkGetCalibratedTimestampsEXT_ptr;
		public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
			=> vkGetCalibratedTimestampsEXT_ptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksNVDelegate(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
		private static vkCmdDrawMeshTasksNVDelegate vkCmdDrawMeshTasksNV_ptr;
		public static void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
			=> vkCmdDrawMeshTasksNV_ptr(commandBuffer, taskCount, firstTask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectNVDelegate vkCmdDrawMeshTasksIndirectNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectNV_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectCountNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectCountNVDelegate vkCmdDrawMeshTasksIndirectCountNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectCountNV_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetExclusiveScissorNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors);
		private static vkCmdSetExclusiveScissorNVDelegate vkCmdSetExclusiveScissorNV_ptr;
		public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
			=> vkCmdSetExclusiveScissorNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCheckpointNVDelegate(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
		private static vkCmdSetCheckpointNVDelegate vkCmdSetCheckpointNV_ptr;
		public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
			=> vkCmdSetCheckpointNV_ptr(commandBuffer, pCheckpointMarker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetQueueCheckpointDataNVDelegate(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);
		private static vkGetQueueCheckpointDataNVDelegate vkGetQueueCheckpointDataNV_ptr;
		public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
			=> vkGetQueueCheckpointDataNV_ptr(queue, pCheckpointDataCount, pCheckpointData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInitializePerformanceApiINTELDelegate(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo);
		private static vkInitializePerformanceApiINTELDelegate vkInitializePerformanceApiINTEL_ptr;
		public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
			=> vkInitializePerformanceApiINTEL_ptr(device, pInitializeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUninitializePerformanceApiINTELDelegate(VkDevice device);
		private static vkUninitializePerformanceApiINTELDelegate vkUninitializePerformanceApiINTEL_ptr;
		public static void vkUninitializePerformanceApiINTEL(VkDevice device)
			=> vkUninitializePerformanceApiINTEL_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo);
		private static vkCmdSetPerformanceMarkerINTELDelegate vkCmdSetPerformanceMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
			=> vkCmdSetPerformanceMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);
		private static vkCmdSetPerformanceStreamMarkerINTELDelegate vkCmdSetPerformanceStreamMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
			=> vkCmdSetPerformanceStreamMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo);
		private static vkCmdSetPerformanceOverrideINTELDelegate vkCmdSetPerformanceOverrideINTEL_ptr;
		public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
			=> vkCmdSetPerformanceOverrideINTEL_ptr(commandBuffer, pOverrideInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration);
		private static vkAcquirePerformanceConfigurationINTELDelegate vkAcquirePerformanceConfigurationINTEL_ptr;
		public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
			=> vkAcquirePerformanceConfigurationINTEL_ptr(device, pAcquireInfo, pConfiguration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleasePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationINTEL configuration);
		private static vkReleasePerformanceConfigurationINTELDelegate vkReleasePerformanceConfigurationINTEL_ptr;
		public static VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
			=> vkReleasePerformanceConfigurationINTEL_ptr(device, configuration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSetPerformanceConfigurationINTELDelegate(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
		private static vkQueueSetPerformanceConfigurationINTELDelegate vkQueueSetPerformanceConfigurationINTEL_ptr;
		public static VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
			=> vkQueueSetPerformanceConfigurationINTEL_ptr(queue, configuration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPerformanceParameterINTELDelegate(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue);
		private static vkGetPerformanceParameterINTELDelegate vkGetPerformanceParameterINTEL_ptr;
		public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
			=> vkGetPerformanceParameterINTEL_ptr(device, parameter, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetLocalDimmingAMDDelegate(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
		private static vkSetLocalDimmingAMDDelegate vkSetLocalDimmingAMD_ptr;
		public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
			=> vkSetLocalDimmingAMD_ptr(device, swapChain, localDimmingEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImagePipeSurfaceFUCHSIADelegate(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateImagePipeSurfaceFUCHSIADelegate vkCreateImagePipeSurfaceFUCHSIA_ptr;
		public static VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateImagePipeSurfaceFUCHSIA_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMetalSurfaceEXTDelegate(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateMetalSurfaceEXTDelegate vkCreateMetalSurfaceEXT_ptr;
		public static VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateMetalSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);
		private static vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
			=> vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFragmentShadingRateKHRDelegate(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private static vkCmdSetFragmentShadingRateKHRDelegate vkCmdSetFragmentShadingRateKHR_ptr;
		public static void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
			=> vkCmdSetFragmentShadingRateKHR_ptr(commandBuffer, pFragmentSize, combinerOps);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);
		private static vkGetPhysicalDeviceToolPropertiesEXTDelegate vkGetPhysicalDeviceToolPropertiesEXT_ptr;
		public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties)
			=> vkGetPhysicalDeviceToolPropertiesEXT_ptr(physicalDevice, pToolCount, pToolProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);
		private static vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
			=> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);
		private static vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;
		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
			=> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr(physicalDevice, pCombinationCount, pCombinations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkAcquireFullScreenExclusiveModeEXTDelegate vkAcquireFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkAcquireFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleaseFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkReleaseFullScreenExclusiveModeEXTDelegate vkReleaseFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkReleaseFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateHeadlessSurfaceEXTDelegate(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateHeadlessSurfaceEXTDelegate vkCreateHeadlessSurfaceEXT_ptr;
		public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateHeadlessSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineStippleEXTDelegate(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		private static vkCmdSetLineStippleEXTDelegate vkCmdSetLineStippleEXT_ptr;
		public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
			=> vkCmdSetLineStippleEXT_ptr(commandBuffer, lineStippleFactor, lineStipplePattern);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCullModeEXTDelegate(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
		private static vkCmdSetCullModeEXTDelegate vkCmdSetCullModeEXT_ptr;
		public static void vkCmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode)
			=> vkCmdSetCullModeEXT_ptr(commandBuffer, cullMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFrontFaceEXTDelegate(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
		private static vkCmdSetFrontFaceEXTDelegate vkCmdSetFrontFaceEXT_ptr;
		public static void vkCmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
			=> vkCmdSetFrontFaceEXT_ptr(commandBuffer, frontFace);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPrimitiveTopologyEXTDelegate(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
		private static vkCmdSetPrimitiveTopologyEXTDelegate vkCmdSetPrimitiveTopologyEXT_ptr;
		public static void vkCmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
			=> vkCmdSetPrimitiveTopologyEXT_ptr(commandBuffer, primitiveTopology);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWithCountEXTDelegate(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports);
		private static vkCmdSetViewportWithCountEXTDelegate vkCmdSetViewportWithCountEXT_ptr;
		public static void vkCmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
			=> vkCmdSetViewportWithCountEXT_ptr(commandBuffer, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetScissorWithCountEXTDelegate(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors);
		private static vkCmdSetScissorWithCountEXTDelegate vkCmdSetScissorWithCountEXT_ptr;
		public static void vkCmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
			=> vkCmdSetScissorWithCountEXT_ptr(commandBuffer, scissorCount, pScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindVertexBuffers2EXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides);
		private static vkCmdBindVertexBuffers2EXTDelegate vkCmdBindVertexBuffers2EXT_ptr;
		public static void vkCmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
			=> vkCmdBindVertexBuffers2EXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
		private static vkCmdSetDepthTestEnableEXTDelegate vkCmdSetDepthTestEnableEXT_ptr;
		public static void vkCmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
			=> vkCmdSetDepthTestEnableEXT_ptr(commandBuffer, depthTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthWriteEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
		private static vkCmdSetDepthWriteEnableEXTDelegate vkCmdSetDepthWriteEnableEXT_ptr;
		public static void vkCmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
			=> vkCmdSetDepthWriteEnableEXT_ptr(commandBuffer, depthWriteEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthCompareOpEXTDelegate(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
		private static vkCmdSetDepthCompareOpEXTDelegate vkCmdSetDepthCompareOpEXT_ptr;
		public static void vkCmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
			=> vkCmdSetDepthCompareOpEXT_ptr(commandBuffer, depthCompareOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBoundsTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
		private static vkCmdSetDepthBoundsTestEnableEXTDelegate vkCmdSetDepthBoundsTestEnableEXT_ptr;
		public static void vkCmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
			=> vkCmdSetDepthBoundsTestEnableEXT_ptr(commandBuffer, depthBoundsTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
		private static vkCmdSetStencilTestEnableEXTDelegate vkCmdSetStencilTestEnableEXT_ptr;
		public static void vkCmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
			=> vkCmdSetStencilTestEnableEXT_ptr(commandBuffer, stencilTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilOpEXTDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
		private static vkCmdSetStencilOpEXTDelegate vkCmdSetStencilOpEXT_ptr;
		public static void vkCmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
			=> vkCmdSetStencilOpEXT_ptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeferredOperationKHRDelegate(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation);
		private static vkCreateDeferredOperationKHRDelegate vkCreateDeferredOperationKHR_ptr;
		public static VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
			=> vkCreateDeferredOperationKHR_ptr(device, pAllocator, pDeferredOperation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeferredOperationKHRDelegate(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDeferredOperationKHRDelegate vkDestroyDeferredOperationKHR_ptr;
		public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDeferredOperationKHR_ptr(device, operation, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetDeferredOperationMaxConcurrencyKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationMaxConcurrencyKHRDelegate vkGetDeferredOperationMaxConcurrencyKHR_ptr;
		public static uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationMaxConcurrencyKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeferredOperationResultKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationResultKHRDelegate vkGetDeferredOperationResultKHR_ptr;
		public static VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationResultKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDeferredOperationJoinKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkDeferredOperationJoinKHRDelegate vkDeferredOperationJoinKHR_ptr;
		public static VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkDeferredOperationJoinKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);
		private static vkGetPipelineExecutablePropertiesKHRDelegate vkGetPipelineExecutablePropertiesKHR_ptr;
		public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
			=> vkGetPipelineExecutablePropertiesKHR_ptr(device, pPipelineInfo, pExecutableCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);
		private static vkGetPipelineExecutableStatisticsKHRDelegate vkGetPipelineExecutableStatisticsKHR_ptr;
		public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
			=> vkGetPipelineExecutableStatisticsKHR_ptr(device, pExecutableInfo, pStatisticCount, pStatistics);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);
		private static vkGetPipelineExecutableInternalRepresentationsKHRDelegate vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
			=> vkGetPipelineExecutableInternalRepresentationsKHR_ptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetGeneratedCommandsMemoryRequirementsNVDelegate vkGetGeneratedCommandsMemoryRequirementsNV_ptr;
		public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetGeneratedCommandsMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPreprocessGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
		private static vkCmdPreprocessGeneratedCommandsNVDelegate vkCmdPreprocessGeneratedCommandsNV_ptr;
		public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
			=> vkCmdPreprocessGeneratedCommandsNV_ptr(commandBuffer, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdExecuteGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
		private static vkCmdExecuteGeneratedCommandsNVDelegate vkCmdExecuteGeneratedCommandsNV_ptr;
		public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
			=> vkCmdExecuteGeneratedCommandsNV_ptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineShaderGroupNVDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
		private static vkCmdBindPipelineShaderGroupNVDelegate vkCmdBindPipelineShaderGroupNV_ptr;
		public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
			=> vkCmdBindPipelineShaderGroupNV_ptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout);
		private static vkCreateIndirectCommandsLayoutNVDelegate vkCreateIndirectCommandsLayoutNV_ptr;
		public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
			=> vkCreateIndirectCommandsLayoutNV_ptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyIndirectCommandsLayoutNVDelegate vkDestroyIndirectCommandsLayoutNV_ptr;
		public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyIndirectCommandsLayoutNV_ptr(device, indirectCommandsLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePrivateDataSlotEXTDelegate(VkDevice device, VkPrivateDataSlotCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlotEXT* pPrivateDataSlot);
		private static vkCreatePrivateDataSlotEXTDelegate vkCreatePrivateDataSlotEXT_ptr;
		public static VkResult vkCreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlotEXT* pPrivateDataSlot)
			=> vkCreatePrivateDataSlotEXT_ptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPrivateDataSlotEXTDelegate(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPrivateDataSlotEXTDelegate vkDestroyPrivateDataSlotEXT_ptr;
		public static void vkDestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPrivateDataSlotEXT_ptr(device, privateDataSlot, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetPrivateDataEXTDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data);
		private static vkSetPrivateDataEXTDelegate vkSetPrivateDataEXT_ptr;
		public static VkResult vkSetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data)
			=> vkSetPrivateDataEXT_ptr(device, objectType, objectHandle, privateDataSlot, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPrivateDataEXTDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong* pData);
		private static vkGetPrivateDataEXTDelegate vkGetPrivateDataEXT_ptr;
		public static void vkGetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong* pData)
			=> vkGetPrivateDataEXT_ptr(device, objectType, objectHandle, privateDataSlot, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEncodeVideoKHRDelegate(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo);
		private static vkCmdEncodeVideoKHRDelegate vkCmdEncodeVideoKHR_ptr;
		public static void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
			=> vkCmdEncodeVideoKHR_ptr(commandBuffer, pEncodeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetEvent2KHRDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkDependencyInfoKHR* pDependencyInfo);
		private static vkCmdSetEvent2KHRDelegate vkCmdSetEvent2KHR_ptr;
		public static void vkCmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkDependencyInfoKHR* pDependencyInfo)
			=> vkCmdSetEvent2KHR_ptr(commandBuffer, vkEvent, pDependencyInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetEvent2KHRDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, ulong stageMask);
		private static vkCmdResetEvent2KHRDelegate vkCmdResetEvent2KHR_ptr;
		public static void vkCmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent vkEvent, ulong stageMask)
			=> vkCmdResetEvent2KHR_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWaitEvents2KHRDelegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfoKHR* pDependencyInfos);
		private static vkCmdWaitEvents2KHRDelegate vkCmdWaitEvents2KHR_ptr;
		public static void vkCmdWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfoKHR* pDependencyInfos)
			=> vkCmdWaitEvents2KHR_ptr(commandBuffer, eventCount, pEvents, pDependencyInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPipelineBarrier2KHRDelegate(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* pDependencyInfo);
		private static vkCmdPipelineBarrier2KHRDelegate vkCmdPipelineBarrier2KHR_ptr;
		public static void vkCmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* pDependencyInfo)
			=> vkCmdPipelineBarrier2KHR_ptr(commandBuffer, pDependencyInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteTimestamp2KHRDelegate(VkCommandBuffer commandBuffer, ulong stage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestamp2KHRDelegate vkCmdWriteTimestamp2KHR_ptr;
		public static void vkCmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, ulong stage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp2KHR_ptr(commandBuffer, stage, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSubmit2KHRDelegate(VkQueue queue, uint submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence);
		private static vkQueueSubmit2KHRDelegate vkQueueSubmit2KHR_ptr;
		public static VkResult vkQueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence)
			=> vkQueueSubmit2KHR_ptr(queue, submitCount, pSubmits, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFragmentShadingRateEnumNVDelegate(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private static vkCmdSetFragmentShadingRateEnumNVDelegate vkCmdSetFragmentShadingRateEnumNV_ptr;
		public static void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps)
			=> vkCmdSetFragmentShadingRateEnumNV_ptr(commandBuffer, shadingRate, combinerOps);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBuffer2KHRDelegate(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* pCopyBufferInfo);
		private static vkCmdCopyBuffer2KHRDelegate vkCmdCopyBuffer2KHR_ptr;
		public static void vkCmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* pCopyBufferInfo)
			=> vkCmdCopyBuffer2KHR_ptr(commandBuffer, pCopyBufferInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImage2KHRDelegate(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* pCopyImageInfo);
		private static vkCmdCopyImage2KHRDelegate vkCmdCopyImage2KHR_ptr;
		public static void vkCmdCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* pCopyImageInfo)
			=> vkCmdCopyImage2KHR_ptr(commandBuffer, pCopyImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferToImage2KHRDelegate(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);
		private static vkCmdCopyBufferToImage2KHRDelegate vkCmdCopyBufferToImage2KHR_ptr;
		public static void vkCmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo)
			=> vkCmdCopyBufferToImage2KHR_ptr(commandBuffer, pCopyBufferToImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageToBuffer2KHRDelegate(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);
		private static vkCmdCopyImageToBuffer2KHRDelegate vkCmdCopyImageToBuffer2KHR_ptr;
		public static void vkCmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo)
			=> vkCmdCopyImageToBuffer2KHR_ptr(commandBuffer, pCopyImageToBufferInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBlitImage2KHRDelegate(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* pBlitImageInfo);
		private static vkCmdBlitImage2KHRDelegate vkCmdBlitImage2KHR_ptr;
		public static void vkCmdBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* pBlitImageInfo)
			=> vkCmdBlitImage2KHR_ptr(commandBuffer, pBlitImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResolveImage2KHRDelegate(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* pResolveImageInfo);
		private static vkCmdResolveImage2KHRDelegate vkCmdResolveImage2KHR_ptr;
		public static void vkCmdResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* pResolveImageInfo)
			=> vkCmdResolveImage2KHR_ptr(commandBuffer, pResolveImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private static vkAcquireWinrtDisplayNVDelegate vkAcquireWinrtDisplayNV_ptr;
		public static VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
			=> vkAcquireWinrtDisplayNV_ptr(physicalDevice, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay);
		private static vkGetWinrtDisplayNVDelegate vkGetWinrtDisplayNV_ptr;
		public static VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
			=> vkGetWinrtDisplayNV_ptr(physicalDevice, deviceRelativeId, pDisplay);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDirectFBSurfaceEXTDelegate(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateDirectFBSurfaceEXTDelegate vkCreateDirectFBSurfaceEXT_ptr;
		public static VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateDirectFBSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXTDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb);
		private static vkGetPhysicalDeviceDirectFBPresentationSupportEXTDelegate vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr;
		public static VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
			=> vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr(physicalDevice, queueFamilyIndex, dfb);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetVertexInputEXTDelegate(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);
		private static vkCmdSetVertexInputEXTDelegate vkCmdSetVertexInputEXT_ptr;
		public static void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
			=> vkCmdSetVertexInputEXT_ptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryZirconHandleFUCHSIADelegate(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle);
		private static vkGetMemoryZirconHandleFUCHSIADelegate vkGetMemoryZirconHandleFUCHSIA_ptr;
		public static VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle)
			=> vkGetMemoryZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryZirconHandlePropertiesFUCHSIADelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties);
		private static vkGetMemoryZirconHandlePropertiesFUCHSIADelegate vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr;
		public static VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
			=> vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreZirconHandleFUCHSIADelegate(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo);
		private static vkImportSemaphoreZirconHandleFUCHSIADelegate vkImportSemaphoreZirconHandleFUCHSIA_ptr;
		public static VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
			=> vkImportSemaphoreZirconHandleFUCHSIA_ptr(device, pImportSemaphoreZirconHandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreZirconHandleFUCHSIADelegate(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle);
		private static vkGetSemaphoreZirconHandleFUCHSIADelegate vkGetSemaphoreZirconHandleFUCHSIA_ptr;
		public static VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle)
			=> vkGetSemaphoreZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPatchControlPointsEXTDelegate(VkCommandBuffer commandBuffer, uint patchControlPoints);
		private static vkCmdSetPatchControlPointsEXTDelegate vkCmdSetPatchControlPointsEXT_ptr;
		public static void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
			=> vkCmdSetPatchControlPointsEXT_ptr(commandBuffer, patchControlPoints);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRasterizerDiscardEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
		private static vkCmdSetRasterizerDiscardEnableEXTDelegate vkCmdSetRasterizerDiscardEnableEXT_ptr;
		public static void vkCmdSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable)
			=> vkCmdSetRasterizerDiscardEnableEXT_ptr(commandBuffer, rasterizerDiscardEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBiasEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
		private static vkCmdSetDepthBiasEnableEXTDelegate vkCmdSetDepthBiasEnableEXT_ptr;
		public static void vkCmdSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable)
			=> vkCmdSetDepthBiasEnableEXT_ptr(commandBuffer, depthBiasEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLogicOpEXTDelegate(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
		private static vkCmdSetLogicOpEXTDelegate vkCmdSetLogicOpEXT_ptr;
		public static void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
			=> vkCmdSetLogicOpEXT_ptr(commandBuffer, logicOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPrimitiveRestartEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
		private static vkCmdSetPrimitiveRestartEnableEXTDelegate vkCmdSetPrimitiveRestartEnableEXT_ptr;
		public static void vkCmdSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable)
			=> vkCmdSetPrimitiveRestartEnableEXT_ptr(commandBuffer, primitiveRestartEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateScreenSurfaceQNXDelegate(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateScreenSurfaceQNXDelegate vkCreateScreenSurfaceQNX_ptr;
		public static VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateScreenSurfaceQNX_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNXDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr window);
		private static vkGetPhysicalDeviceScreenPresentationSupportQNXDelegate vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr;
		public static VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr window)
			=> vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr(physicalDevice, queueFamilyIndex, window);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorWriteEnableEXTDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables);
		private static vkCmdSetColorWriteEnableEXTDelegate vkCmdSetColorWriteEnableEXT_ptr;
		public static void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
			=> vkCmdSetColorWriteEnableEXT_ptr(commandBuffer, attachmentCount, pColorWriteEnables);

		public static void LoadFuncionPointers(VkInstance instance = default)
		{
			if (instance != default)
			{
				nativeLib.instance = instance;
			}

			nativeLib.LoadFunction("vkCreateInstance",  out vkCreateInstance_ptr);
			nativeLib.LoadFunction("vkDestroyInstance",  out vkDestroyInstance_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDevices",  out vkEnumeratePhysicalDevices_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFeatures",  out vkGetPhysicalDeviceFeatures_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties",  out vkGetPhysicalDeviceFormatProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties",  out vkGetPhysicalDeviceImageFormatProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceProperties",  out vkGetPhysicalDeviceProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties",  out vkGetPhysicalDeviceQueueFamilyProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties",  out vkGetPhysicalDeviceMemoryProperties_ptr);
			nativeLib.LoadFunction("vkGetInstanceProcAddr",  out vkGetInstanceProcAddr_ptr);
			nativeLib.LoadFunction("vkGetDeviceProcAddr",  out vkGetDeviceProcAddr_ptr);
			nativeLib.LoadFunction("vkCreateDevice",  out vkCreateDevice_ptr);
			nativeLib.LoadFunction("vkDestroyDevice",  out vkDestroyDevice_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceExtensionProperties",  out vkEnumerateInstanceExtensionProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateDeviceExtensionProperties",  out vkEnumerateDeviceExtensionProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceLayerProperties",  out vkEnumerateInstanceLayerProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateDeviceLayerProperties",  out vkEnumerateDeviceLayerProperties_ptr);
			nativeLib.LoadFunction("vkGetDeviceQueue",  out vkGetDeviceQueue_ptr);
			nativeLib.LoadFunction("vkQueueSubmit",  out vkQueueSubmit_ptr);
			nativeLib.LoadFunction("vkQueueWaitIdle",  out vkQueueWaitIdle_ptr);
			nativeLib.LoadFunction("vkDeviceWaitIdle",  out vkDeviceWaitIdle_ptr);
			nativeLib.LoadFunction("vkAllocateMemory",  out vkAllocateMemory_ptr);
			nativeLib.LoadFunction("vkFreeMemory",  out vkFreeMemory_ptr);
			nativeLib.LoadFunction("vkMapMemory",  out vkMapMemory_ptr);
			nativeLib.LoadFunction("vkUnmapMemory",  out vkUnmapMemory_ptr);
			nativeLib.LoadFunction("vkFlushMappedMemoryRanges",  out vkFlushMappedMemoryRanges_ptr);
			nativeLib.LoadFunction("vkInvalidateMappedMemoryRanges",  out vkInvalidateMappedMemoryRanges_ptr);
			nativeLib.LoadFunction("vkGetDeviceMemoryCommitment",  out vkGetDeviceMemoryCommitment_ptr);
			nativeLib.LoadFunction("vkBindBufferMemory",  out vkBindBufferMemory_ptr);
			nativeLib.LoadFunction("vkBindImageMemory",  out vkBindImageMemory_ptr);
			nativeLib.LoadFunction("vkGetBufferMemoryRequirements",  out vkGetBufferMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkGetImageMemoryRequirements",  out vkGetImageMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkGetImageSparseMemoryRequirements",  out vkGetImageSparseMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties",  out vkGetPhysicalDeviceSparseImageFormatProperties_ptr);
			nativeLib.LoadFunction("vkQueueBindSparse",  out vkQueueBindSparse_ptr);
			nativeLib.LoadFunction("vkCreateFence",  out vkCreateFence_ptr);
			nativeLib.LoadFunction("vkDestroyFence",  out vkDestroyFence_ptr);
			nativeLib.LoadFunction("vkResetFences",  out vkResetFences_ptr);
			nativeLib.LoadFunction("vkGetFenceStatus",  out vkGetFenceStatus_ptr);
			nativeLib.LoadFunction("vkWaitForFences",  out vkWaitForFences_ptr);
			nativeLib.LoadFunction("vkCreateSemaphore",  out vkCreateSemaphore_ptr);
			nativeLib.LoadFunction("vkDestroySemaphore",  out vkDestroySemaphore_ptr);
			nativeLib.LoadFunction("vkCreateEvent",  out vkCreateEvent_ptr);
			nativeLib.LoadFunction("vkDestroyEvent",  out vkDestroyEvent_ptr);
			nativeLib.LoadFunction("vkGetEventStatus",  out vkGetEventStatus_ptr);
			nativeLib.LoadFunction("vkSetEvent",  out vkSetEvent_ptr);
			nativeLib.LoadFunction("vkResetEvent",  out vkResetEvent_ptr);
			nativeLib.LoadFunction("vkCreateQueryPool",  out vkCreateQueryPool_ptr);
			nativeLib.LoadFunction("vkDestroyQueryPool",  out vkDestroyQueryPool_ptr);
			nativeLib.LoadFunction("vkGetQueryPoolResults",  out vkGetQueryPoolResults_ptr);
			nativeLib.LoadFunction("vkCreateBuffer",  out vkCreateBuffer_ptr);
			nativeLib.LoadFunction("vkDestroyBuffer",  out vkDestroyBuffer_ptr);
			nativeLib.LoadFunction("vkCreateBufferView",  out vkCreateBufferView_ptr);
			nativeLib.LoadFunction("vkDestroyBufferView",  out vkDestroyBufferView_ptr);
			nativeLib.LoadFunction("vkCreateImage",  out vkCreateImage_ptr);
			nativeLib.LoadFunction("vkDestroyImage",  out vkDestroyImage_ptr);
			nativeLib.LoadFunction("vkGetImageSubresourceLayout",  out vkGetImageSubresourceLayout_ptr);
			nativeLib.LoadFunction("vkCreateImageView",  out vkCreateImageView_ptr);
			nativeLib.LoadFunction("vkDestroyImageView",  out vkDestroyImageView_ptr);
			nativeLib.LoadFunction("vkCreateShaderModule",  out vkCreateShaderModule_ptr);
			nativeLib.LoadFunction("vkDestroyShaderModule",  out vkDestroyShaderModule_ptr);
			nativeLib.LoadFunction("vkCreatePipelineCache",  out vkCreatePipelineCache_ptr);
			nativeLib.LoadFunction("vkDestroyPipelineCache",  out vkDestroyPipelineCache_ptr);
			nativeLib.LoadFunction("vkGetPipelineCacheData",  out vkGetPipelineCacheData_ptr);
			nativeLib.LoadFunction("vkMergePipelineCaches",  out vkMergePipelineCaches_ptr);
			nativeLib.LoadFunction("vkCreateGraphicsPipelines",  out vkCreateGraphicsPipelines_ptr);
			nativeLib.LoadFunction("vkCreateComputePipelines",  out vkCreateComputePipelines_ptr);
			nativeLib.LoadFunction("vkDestroyPipeline",  out vkDestroyPipeline_ptr);
			nativeLib.LoadFunction("vkCreatePipelineLayout",  out vkCreatePipelineLayout_ptr);
			nativeLib.LoadFunction("vkDestroyPipelineLayout",  out vkDestroyPipelineLayout_ptr);
			nativeLib.LoadFunction("vkCreateSampler",  out vkCreateSampler_ptr);
			nativeLib.LoadFunction("vkDestroySampler",  out vkDestroySampler_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorSetLayout",  out vkCreateDescriptorSetLayout_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorSetLayout",  out vkDestroyDescriptorSetLayout_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorPool",  out vkCreateDescriptorPool_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorPool",  out vkDestroyDescriptorPool_ptr);
			nativeLib.LoadFunction("vkResetDescriptorPool",  out vkResetDescriptorPool_ptr);
			nativeLib.LoadFunction("vkAllocateDescriptorSets",  out vkAllocateDescriptorSets_ptr);
			nativeLib.LoadFunction("vkFreeDescriptorSets",  out vkFreeDescriptorSets_ptr);
			nativeLib.LoadFunction("vkUpdateDescriptorSets",  out vkUpdateDescriptorSets_ptr);
			nativeLib.LoadFunction("vkCreateFramebuffer",  out vkCreateFramebuffer_ptr);
			nativeLib.LoadFunction("vkDestroyFramebuffer",  out vkDestroyFramebuffer_ptr);
			nativeLib.LoadFunction("vkCreateRenderPass",  out vkCreateRenderPass_ptr);
			nativeLib.LoadFunction("vkDestroyRenderPass",  out vkDestroyRenderPass_ptr);
			nativeLib.LoadFunction("vkGetRenderAreaGranularity",  out vkGetRenderAreaGranularity_ptr);
			nativeLib.LoadFunction("vkCreateCommandPool",  out vkCreateCommandPool_ptr);
			nativeLib.LoadFunction("vkDestroyCommandPool",  out vkDestroyCommandPool_ptr);
			nativeLib.LoadFunction("vkResetCommandPool",  out vkResetCommandPool_ptr);
			nativeLib.LoadFunction("vkAllocateCommandBuffers",  out vkAllocateCommandBuffers_ptr);
			nativeLib.LoadFunction("vkFreeCommandBuffers",  out vkFreeCommandBuffers_ptr);
			nativeLib.LoadFunction("vkBeginCommandBuffer",  out vkBeginCommandBuffer_ptr);
			nativeLib.LoadFunction("vkEndCommandBuffer",  out vkEndCommandBuffer_ptr);
			nativeLib.LoadFunction("vkResetCommandBuffer",  out vkResetCommandBuffer_ptr);
			nativeLib.LoadFunction("vkCmdBindPipeline",  out vkCmdBindPipeline_ptr);
			nativeLib.LoadFunction("vkCmdSetViewport",  out vkCmdSetViewport_ptr);
			nativeLib.LoadFunction("vkCmdSetScissor",  out vkCmdSetScissor_ptr);
			nativeLib.LoadFunction("vkCmdSetLineWidth",  out vkCmdSetLineWidth_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBias",  out vkCmdSetDepthBias_ptr);
			nativeLib.LoadFunction("vkCmdSetBlendConstants",  out vkCmdSetBlendConstants_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBounds",  out vkCmdSetDepthBounds_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilCompareMask",  out vkCmdSetStencilCompareMask_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilWriteMask",  out vkCmdSetStencilWriteMask_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilReference",  out vkCmdSetStencilReference_ptr);
			nativeLib.LoadFunction("vkCmdBindDescriptorSets",  out vkCmdBindDescriptorSets_ptr);
			nativeLib.LoadFunction("vkCmdBindIndexBuffer",  out vkCmdBindIndexBuffer_ptr);
			nativeLib.LoadFunction("vkCmdBindVertexBuffers",  out vkCmdBindVertexBuffers_ptr);
			nativeLib.LoadFunction("vkCmdDraw",  out vkCmdDraw_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexed",  out vkCmdDrawIndexed_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirect",  out vkCmdDrawIndirect_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexedIndirect",  out vkCmdDrawIndexedIndirect_ptr);
			nativeLib.LoadFunction("vkCmdDispatch",  out vkCmdDispatch_ptr);
			nativeLib.LoadFunction("vkCmdDispatchIndirect",  out vkCmdDispatchIndirect_ptr);
			nativeLib.LoadFunction("vkCmdCopyBuffer",  out vkCmdCopyBuffer_ptr);
			nativeLib.LoadFunction("vkCmdCopyImage",  out vkCmdCopyImage_ptr);
			nativeLib.LoadFunction("vkCmdBlitImage",  out vkCmdBlitImage_ptr);
			nativeLib.LoadFunction("vkCmdCopyBufferToImage",  out vkCmdCopyBufferToImage_ptr);
			nativeLib.LoadFunction("vkCmdCopyImageToBuffer",  out vkCmdCopyImageToBuffer_ptr);
			nativeLib.LoadFunction("vkCmdUpdateBuffer",  out vkCmdUpdateBuffer_ptr);
			nativeLib.LoadFunction("vkCmdFillBuffer",  out vkCmdFillBuffer_ptr);
			nativeLib.LoadFunction("vkCmdClearColorImage",  out vkCmdClearColorImage_ptr);
			nativeLib.LoadFunction("vkCmdClearDepthStencilImage",  out vkCmdClearDepthStencilImage_ptr);
			nativeLib.LoadFunction("vkCmdClearAttachments",  out vkCmdClearAttachments_ptr);
			nativeLib.LoadFunction("vkCmdResolveImage",  out vkCmdResolveImage_ptr);
			nativeLib.LoadFunction("vkCmdSetEvent",  out vkCmdSetEvent_ptr);
			nativeLib.LoadFunction("vkCmdResetEvent",  out vkCmdResetEvent_ptr);
			nativeLib.LoadFunction("vkCmdWaitEvents",  out vkCmdWaitEvents_ptr);
			nativeLib.LoadFunction("vkCmdPipelineBarrier",  out vkCmdPipelineBarrier_ptr);
			nativeLib.LoadFunction("vkCmdBeginQuery",  out vkCmdBeginQuery_ptr);
			nativeLib.LoadFunction("vkCmdEndQuery",  out vkCmdEndQuery_ptr);
			nativeLib.LoadFunction("vkCmdResetQueryPool",  out vkCmdResetQueryPool_ptr);
			nativeLib.LoadFunction("vkCmdWriteTimestamp",  out vkCmdWriteTimestamp_ptr);
			nativeLib.LoadFunction("vkCmdCopyQueryPoolResults",  out vkCmdCopyQueryPoolResults_ptr);
			nativeLib.LoadFunction("vkCmdPushConstants",  out vkCmdPushConstants_ptr);
			nativeLib.LoadFunction("vkCmdBeginRenderPass",  out vkCmdBeginRenderPass_ptr);
			nativeLib.LoadFunction("vkCmdNextSubpass",  out vkCmdNextSubpass_ptr);
			nativeLib.LoadFunction("vkCmdEndRenderPass",  out vkCmdEndRenderPass_ptr);
			nativeLib.LoadFunction("vkCmdExecuteCommands",  out vkCmdExecuteCommands_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceVersion",  out vkEnumerateInstanceVersion_ptr);
			nativeLib.LoadFunction("vkBindBufferMemory2",  out vkBindBufferMemory2_ptr);
			nativeLib.LoadFunction("vkBindImageMemory2",  out vkBindImageMemory2_ptr);
			nativeLib.LoadFunction("vkGetDeviceGroupPeerMemoryFeatures",  out vkGetDeviceGroupPeerMemoryFeatures_ptr);
			nativeLib.LoadFunction("vkCmdSetDeviceMask",  out vkCmdSetDeviceMask_ptr);
			nativeLib.LoadFunction("vkCmdDispatchBase",  out vkCmdDispatchBase_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDeviceGroups",  out vkEnumeratePhysicalDeviceGroups_ptr);
			nativeLib.LoadFunction("vkGetImageMemoryRequirements2",  out vkGetImageMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkGetBufferMemoryRequirements2",  out vkGetBufferMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkGetImageSparseMemoryRequirements2",  out vkGetImageSparseMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFeatures2",  out vkGetPhysicalDeviceFeatures2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceProperties2",  out vkGetPhysicalDeviceProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties2",  out vkGetPhysicalDeviceFormatProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties2",  out vkGetPhysicalDeviceImageFormatProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties2",  out vkGetPhysicalDeviceQueueFamilyProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties2",  out vkGetPhysicalDeviceMemoryProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties2",  out vkGetPhysicalDeviceSparseImageFormatProperties2_ptr);
			nativeLib.LoadFunction("vkTrimCommandPool",  out vkTrimCommandPool_ptr);
			nativeLib.LoadFunction("vkGetDeviceQueue2",  out vkGetDeviceQueue2_ptr);
			nativeLib.LoadFunction("vkCreateSamplerYcbcrConversion",  out vkCreateSamplerYcbcrConversion_ptr);
			nativeLib.LoadFunction("vkDestroySamplerYcbcrConversion",  out vkDestroySamplerYcbcrConversion_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorUpdateTemplate",  out vkCreateDescriptorUpdateTemplate_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorUpdateTemplate",  out vkDestroyDescriptorUpdateTemplate_ptr);
			nativeLib.LoadFunction("vkUpdateDescriptorSetWithTemplate",  out vkUpdateDescriptorSetWithTemplate_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalBufferProperties",  out vkGetPhysicalDeviceExternalBufferProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalFenceProperties",  out vkGetPhysicalDeviceExternalFenceProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalSemaphoreProperties",  out vkGetPhysicalDeviceExternalSemaphoreProperties_ptr);
			nativeLib.LoadFunction("vkGetDescriptorSetLayoutSupport",  out vkGetDescriptorSetLayoutSupport_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirectCount",  out vkCmdDrawIndirectCount_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexedIndirectCount",  out vkCmdDrawIndexedIndirectCount_ptr);
			nativeLib.LoadFunction("vkCreateRenderPass2",  out vkCreateRenderPass2_ptr);
			nativeLib.LoadFunction("vkCmdBeginRenderPass2",  out vkCmdBeginRenderPass2_ptr);
			nativeLib.LoadFunction("vkCmdNextSubpass2",  out vkCmdNextSubpass2_ptr);
			nativeLib.LoadFunction("vkCmdEndRenderPass2",  out vkCmdEndRenderPass2_ptr);
			nativeLib.LoadFunction("vkResetQueryPool",  out vkResetQueryPool_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreCounterValue",  out vkGetSemaphoreCounterValue_ptr);
			nativeLib.LoadFunction("vkWaitSemaphores",  out vkWaitSemaphores_ptr);
			nativeLib.LoadFunction("vkSignalSemaphore",  out vkSignalSemaphore_ptr);
			nativeLib.LoadFunction("vkGetBufferDeviceAddress",  out vkGetBufferDeviceAddress_ptr);
			nativeLib.LoadFunction("vkGetBufferOpaqueCaptureAddress",  out vkGetBufferOpaqueCaptureAddress_ptr);
			nativeLib.LoadFunction("vkGetDeviceMemoryOpaqueCaptureAddress",  out vkGetDeviceMemoryOpaqueCaptureAddress_ptr);
			nativeLib.LoadFunction("vkDestroySurfaceKHR",  out vkDestroySurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceSupportKHR",  out vkGetPhysicalDeviceSurfaceSupportKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilitiesKHR",  out vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormatsKHR",  out vkGetPhysicalDeviceSurfaceFormatsKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModesKHR",  out vkGetPhysicalDeviceSurfacePresentModesKHR_ptr);
			nativeLib.LoadFunction("vkCreateSwapchainKHR",  out vkCreateSwapchainKHR_ptr);
			nativeLib.LoadFunction("vkDestroySwapchainKHR",  out vkDestroySwapchainKHR_ptr);
			nativeLib.LoadFunction("vkGetSwapchainImagesKHR",  out vkGetSwapchainImagesKHR_ptr);
			nativeLib.LoadFunction("vkAcquireNextImageKHR",  out vkAcquireNextImageKHR_ptr);
			nativeLib.LoadFunction("vkQueuePresentKHR",  out vkQueuePresentKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPropertiesKHR",  out vkGetPhysicalDeviceDisplayPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlanePropertiesKHR",  out vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneSupportedDisplaysKHR",  out vkGetDisplayPlaneSupportedDisplaysKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayModePropertiesKHR",  out vkGetDisplayModePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCreateDisplayModeKHR",  out vkCreateDisplayModeKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneCapabilitiesKHR",  out vkGetDisplayPlaneCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkCreateDisplayPlaneSurfaceKHR",  out vkCreateDisplayPlaneSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkCreateSharedSwapchainsKHR",  out vkCreateSharedSwapchainsKHR_ptr);
			nativeLib.LoadFunction("vkCreateXlibSurfaceKHR",  out vkCreateXlibSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceXlibPresentationSupportKHR",  out vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateXcbSurfaceKHR",  out vkCreateXcbSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceXcbPresentationSupportKHR",  out vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateWaylandSurfaceKHR",  out vkCreateWaylandSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceWaylandPresentationSupportKHR",  out vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateAndroidSurfaceKHR",  out vkCreateAndroidSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkCreateWin32SurfaceKHR",  out vkCreateWin32SurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceWin32PresentationSupportKHR",  out vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateDebugReportCallbackEXT",  out vkCreateDebugReportCallbackEXT_ptr);
			nativeLib.LoadFunction("vkDestroyDebugReportCallbackEXT",  out vkDestroyDebugReportCallbackEXT_ptr);
			nativeLib.LoadFunction("vkDebugReportMessageEXT",  out vkDebugReportMessageEXT_ptr);
			nativeLib.LoadFunction("vkDebugMarkerSetObjectTagEXT",  out vkDebugMarkerSetObjectTagEXT_ptr);
			nativeLib.LoadFunction("vkDebugMarkerSetObjectNameEXT",  out vkDebugMarkerSetObjectNameEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerBeginEXT",  out vkCmdDebugMarkerBeginEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerEndEXT",  out vkCmdDebugMarkerEndEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerInsertEXT",  out vkCmdDebugMarkerInsertEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceVideoCapabilitiesKHR",  out vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceVideoFormatPropertiesKHR",  out vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCreateVideoSessionKHR",  out vkCreateVideoSessionKHR_ptr);
			nativeLib.LoadFunction("vkDestroyVideoSessionKHR",  out vkDestroyVideoSessionKHR_ptr);
			nativeLib.LoadFunction("vkGetVideoSessionMemoryRequirementsKHR",  out vkGetVideoSessionMemoryRequirementsKHR_ptr);
			nativeLib.LoadFunction("vkBindVideoSessionMemoryKHR",  out vkBindVideoSessionMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCreateVideoSessionParametersKHR",  out vkCreateVideoSessionParametersKHR_ptr);
			nativeLib.LoadFunction("vkUpdateVideoSessionParametersKHR",  out vkUpdateVideoSessionParametersKHR_ptr);
			nativeLib.LoadFunction("vkDestroyVideoSessionParametersKHR",  out vkDestroyVideoSessionParametersKHR_ptr);
			nativeLib.LoadFunction("vkCmdBeginVideoCodingKHR",  out vkCmdBeginVideoCodingKHR_ptr);
			nativeLib.LoadFunction("vkCmdEndVideoCodingKHR",  out vkCmdEndVideoCodingKHR_ptr);
			nativeLib.LoadFunction("vkCmdControlVideoCodingKHR",  out vkCmdControlVideoCodingKHR_ptr);
			nativeLib.LoadFunction("vkCmdDecodeVideoKHR",  out vkCmdDecodeVideoKHR_ptr);
			nativeLib.LoadFunction("vkCmdBindTransformFeedbackBuffersEXT",  out vkCmdBindTransformFeedbackBuffersEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginTransformFeedbackEXT",  out vkCmdBeginTransformFeedbackEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndTransformFeedbackEXT",  out vkCmdEndTransformFeedbackEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginQueryIndexedEXT",  out vkCmdBeginQueryIndexedEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndQueryIndexedEXT",  out vkCmdEndQueryIndexedEXT_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirectByteCountEXT",  out vkCmdDrawIndirectByteCountEXT_ptr);
			nativeLib.LoadFunction("vkCreateCuModuleNVX",  out vkCreateCuModuleNVX_ptr);
			nativeLib.LoadFunction("vkCreateCuFunctionNVX",  out vkCreateCuFunctionNVX_ptr);
			nativeLib.LoadFunction("vkDestroyCuModuleNVX",  out vkDestroyCuModuleNVX_ptr);
			nativeLib.LoadFunction("vkDestroyCuFunctionNVX",  out vkDestroyCuFunctionNVX_ptr);
			nativeLib.LoadFunction("vkCmdCuLaunchKernelNVX",  out vkCmdCuLaunchKernelNVX_ptr);
			nativeLib.LoadFunction("vkGetImageViewHandleNVX",  out vkGetImageViewHandleNVX_ptr);
			nativeLib.LoadFunction("vkGetImageViewAddressNVX",  out vkGetImageViewAddressNVX_ptr);
			nativeLib.LoadFunction("vkGetShaderInfoAMD",  out vkGetShaderInfoAMD_ptr);
			nativeLib.LoadFunction("vkCreateStreamDescriptorSurfaceGGP",  out vkCreateStreamDescriptorSurfaceGGP_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalImageFormatPropertiesNV",  out vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandleNV",  out vkGetMemoryWin32HandleNV_ptr);
			nativeLib.LoadFunction("vkCreateViSurfaceNN",  out vkCreateViSurfaceNN_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandleKHR",  out vkGetMemoryWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandlePropertiesKHR",  out vkGetMemoryWin32HandlePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryFdKHR",  out vkGetMemoryFdKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryFdPropertiesKHR",  out vkGetMemoryFdPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkImportSemaphoreWin32HandleKHR",  out vkImportSemaphoreWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreWin32HandleKHR",  out vkGetSemaphoreWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkImportSemaphoreFdKHR",  out vkImportSemaphoreFdKHR_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreFdKHR",  out vkGetSemaphoreFdKHR_ptr);
			nativeLib.LoadFunction("vkCmdPushDescriptorSetKHR",  out vkCmdPushDescriptorSetKHR_ptr);
			nativeLib.LoadFunction("vkCmdBeginConditionalRenderingEXT",  out vkCmdBeginConditionalRenderingEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndConditionalRenderingEXT",  out vkCmdEndConditionalRenderingEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetViewportWScalingNV",  out vkCmdSetViewportWScalingNV_ptr);
			nativeLib.LoadFunction("vkReleaseDisplayEXT",  out vkReleaseDisplayEXT_ptr);
			nativeLib.LoadFunction("vkAcquireXlibDisplayEXT",  out vkAcquireXlibDisplayEXT_ptr);
			nativeLib.LoadFunction("vkGetRandROutputDisplayEXT",  out vkGetRandROutputDisplayEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2EXT",  out vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr);
			nativeLib.LoadFunction("vkDisplayPowerControlEXT",  out vkDisplayPowerControlEXT_ptr);
			nativeLib.LoadFunction("vkRegisterDeviceEventEXT",  out vkRegisterDeviceEventEXT_ptr);
			nativeLib.LoadFunction("vkRegisterDisplayEventEXT",  out vkRegisterDisplayEventEXT_ptr);
			nativeLib.LoadFunction("vkGetSwapchainCounterEXT",  out vkGetSwapchainCounterEXT_ptr);
			nativeLib.LoadFunction("vkGetRefreshCycleDurationGOOGLE",  out vkGetRefreshCycleDurationGOOGLE_ptr);
			nativeLib.LoadFunction("vkGetPastPresentationTimingGOOGLE",  out vkGetPastPresentationTimingGOOGLE_ptr);
			nativeLib.LoadFunction("vkCmdSetDiscardRectangleEXT",  out vkCmdSetDiscardRectangleEXT_ptr);
			nativeLib.LoadFunction("vkSetHdrMetadataEXT",  out vkSetHdrMetadataEXT_ptr);
			nativeLib.LoadFunction("vkGetSwapchainStatusKHR",  out vkGetSwapchainStatusKHR_ptr);
			nativeLib.LoadFunction("vkImportFenceWin32HandleKHR",  out vkImportFenceWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetFenceWin32HandleKHR",  out vkGetFenceWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkImportFenceFdKHR",  out vkImportFenceFdKHR_ptr);
			nativeLib.LoadFunction("vkGetFenceFdKHR",  out vkGetFenceFdKHR_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR",  out vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR",  out vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr);
			nativeLib.LoadFunction("vkAcquireProfilingLockKHR",  out vkAcquireProfilingLockKHR_ptr);
			nativeLib.LoadFunction("vkReleaseProfilingLockKHR",  out vkReleaseProfilingLockKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2KHR",  out vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormats2KHR",  out vkGetPhysicalDeviceSurfaceFormats2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayProperties2KHR",  out vkGetPhysicalDeviceDisplayProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlaneProperties2KHR",  out vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayModeProperties2KHR",  out vkGetDisplayModeProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneCapabilities2KHR",  out vkGetDisplayPlaneCapabilities2KHR_ptr);
			nativeLib.LoadFunction("vkCreateIOSSurfaceMVK",  out vkCreateIOSSurfaceMVK_ptr);
			nativeLib.LoadFunction("vkCreateMacOSSurfaceMVK",  out vkCreateMacOSSurfaceMVK_ptr);
			nativeLib.LoadFunction("vkSetDebugUtilsObjectNameEXT",  out vkSetDebugUtilsObjectNameEXT_ptr);
			nativeLib.LoadFunction("vkSetDebugUtilsObjectTagEXT",  out vkSetDebugUtilsObjectTagEXT_ptr);
			nativeLib.LoadFunction("vkQueueBeginDebugUtilsLabelEXT",  out vkQueueBeginDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkQueueEndDebugUtilsLabelEXT",  out vkQueueEndDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkQueueInsertDebugUtilsLabelEXT",  out vkQueueInsertDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginDebugUtilsLabelEXT",  out vkCmdBeginDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndDebugUtilsLabelEXT",  out vkCmdEndDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdInsertDebugUtilsLabelEXT",  out vkCmdInsertDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCreateDebugUtilsMessengerEXT",  out vkCreateDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("vkDestroyDebugUtilsMessengerEXT",  out vkDestroyDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("vkSubmitDebugUtilsMessageEXT",  out vkSubmitDebugUtilsMessageEXT_ptr);
			nativeLib.LoadFunction("vkGetAndroidHardwareBufferPropertiesANDROID",  out vkGetAndroidHardwareBufferPropertiesANDROID_ptr);
			nativeLib.LoadFunction("vkGetMemoryAndroidHardwareBufferANDROID",  out vkGetMemoryAndroidHardwareBufferANDROID_ptr);
			nativeLib.LoadFunction("vkCmdSetSampleLocationsEXT",  out vkCmdSetSampleLocationsEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMultisamplePropertiesEXT",  out vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr);
			nativeLib.LoadFunction("vkCreateAccelerationStructureKHR",  out vkCreateAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkDestroyAccelerationStructureKHR",  out vkDestroyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructuresKHR",  out vkCmdBuildAccelerationStructuresKHR_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructuresIndirectKHR",  out vkCmdBuildAccelerationStructuresIndirectKHR_ptr);
			nativeLib.LoadFunction("vkBuildAccelerationStructuresKHR",  out vkBuildAccelerationStructuresKHR_ptr);
			nativeLib.LoadFunction("vkCopyAccelerationStructureKHR",  out vkCopyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCopyAccelerationStructureToMemoryKHR",  out vkCopyAccelerationStructureToMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCopyMemoryToAccelerationStructureKHR",  out vkCopyMemoryToAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkWriteAccelerationStructuresPropertiesKHR",  out vkWriteAccelerationStructuresPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureKHR",  out vkCmdCopyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureToMemoryKHR",  out vkCmdCopyAccelerationStructureToMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyMemoryToAccelerationStructureKHR",  out vkCmdCopyMemoryToAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureDeviceAddressKHR",  out vkGetAccelerationStructureDeviceAddressKHR_ptr);
			nativeLib.LoadFunction("vkCmdWriteAccelerationStructuresPropertiesKHR",  out vkCmdWriteAccelerationStructuresPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetDeviceAccelerationStructureCompatibilityKHR",  out vkGetDeviceAccelerationStructureCompatibilityKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureBuildSizesKHR",  out vkGetAccelerationStructureBuildSizesKHR_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysKHR",  out vkCmdTraceRaysKHR_ptr);
			nativeLib.LoadFunction("vkCreateRayTracingPipelinesKHR",  out vkCreateRayTracingPipelinesKHR_ptr);
			nativeLib.LoadFunction("vkGetRayTracingShaderGroupHandlesKHR",  out vkGetRayTracingShaderGroupHandlesKHR_ptr);
			nativeLib.LoadFunction("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR",  out vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysIndirectKHR",  out vkCmdTraceRaysIndirectKHR_ptr);
			nativeLib.LoadFunction("vkGetRayTracingShaderGroupStackSizeKHR",  out vkGetRayTracingShaderGroupStackSizeKHR_ptr);
			nativeLib.LoadFunction("vkCmdSetRayTracingPipelineStackSizeKHR",  out vkCmdSetRayTracingPipelineStackSizeKHR_ptr);
			nativeLib.LoadFunction("vkGetImageDrmFormatModifierPropertiesEXT",  out vkGetImageDrmFormatModifierPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkCreateValidationCacheEXT",  out vkCreateValidationCacheEXT_ptr);
			nativeLib.LoadFunction("vkDestroyValidationCacheEXT",  out vkDestroyValidationCacheEXT_ptr);
			nativeLib.LoadFunction("vkMergeValidationCachesEXT",  out vkMergeValidationCachesEXT_ptr);
			nativeLib.LoadFunction("vkGetValidationCacheDataEXT",  out vkGetValidationCacheDataEXT_ptr);
			nativeLib.LoadFunction("vkCmdBindShadingRateImageNV",  out vkCmdBindShadingRateImageNV_ptr);
			nativeLib.LoadFunction("vkCmdSetViewportShadingRatePaletteNV",  out vkCmdSetViewportShadingRatePaletteNV_ptr);
			nativeLib.LoadFunction("vkCmdSetCoarseSampleOrderNV",  out vkCmdSetCoarseSampleOrderNV_ptr);
			nativeLib.LoadFunction("vkCreateAccelerationStructureNV",  out vkCreateAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkDestroyAccelerationStructureNV",  out vkDestroyAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureMemoryRequirementsNV",  out vkGetAccelerationStructureMemoryRequirementsNV_ptr);
			nativeLib.LoadFunction("vkBindAccelerationStructureMemoryNV",  out vkBindAccelerationStructureMemoryNV_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructureNV",  out vkCmdBuildAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureNV",  out vkCmdCopyAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysNV",  out vkCmdTraceRaysNV_ptr);
			nativeLib.LoadFunction("vkCreateRayTracingPipelinesNV",  out vkCreateRayTracingPipelinesNV_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureHandleNV",  out vkGetAccelerationStructureHandleNV_ptr);
			nativeLib.LoadFunction("vkCmdWriteAccelerationStructuresPropertiesNV",  out vkCmdWriteAccelerationStructuresPropertiesNV_ptr);
			nativeLib.LoadFunction("vkCompileDeferredNV",  out vkCompileDeferredNV_ptr);
			nativeLib.LoadFunction("vkGetMemoryHostPointerPropertiesEXT",  out vkGetMemoryHostPointerPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkCmdWriteBufferMarkerAMD",  out vkCmdWriteBufferMarkerAMD_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT",  out vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr);
			nativeLib.LoadFunction("vkGetCalibratedTimestampsEXT",  out vkGetCalibratedTimestampsEXT_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksNV",  out vkCmdDrawMeshTasksNV_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectNV",  out vkCmdDrawMeshTasksIndirectNV_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectCountNV",  out vkCmdDrawMeshTasksIndirectCountNV_ptr);
			nativeLib.LoadFunction("vkCmdSetExclusiveScissorNV",  out vkCmdSetExclusiveScissorNV_ptr);
			nativeLib.LoadFunction("vkCmdSetCheckpointNV",  out vkCmdSetCheckpointNV_ptr);
			nativeLib.LoadFunction("vkGetQueueCheckpointDataNV",  out vkGetQueueCheckpointDataNV_ptr);
			nativeLib.LoadFunction("vkInitializePerformanceApiINTEL",  out vkInitializePerformanceApiINTEL_ptr);
			nativeLib.LoadFunction("vkUninitializePerformanceApiINTEL",  out vkUninitializePerformanceApiINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceMarkerINTEL",  out vkCmdSetPerformanceMarkerINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceStreamMarkerINTEL",  out vkCmdSetPerformanceStreamMarkerINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceOverrideINTEL",  out vkCmdSetPerformanceOverrideINTEL_ptr);
			nativeLib.LoadFunction("vkAcquirePerformanceConfigurationINTEL",  out vkAcquirePerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkReleasePerformanceConfigurationINTEL",  out vkReleasePerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkQueueSetPerformanceConfigurationINTEL",  out vkQueueSetPerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkGetPerformanceParameterINTEL",  out vkGetPerformanceParameterINTEL_ptr);
			nativeLib.LoadFunction("vkSetLocalDimmingAMD",  out vkSetLocalDimmingAMD_ptr);
			nativeLib.LoadFunction("vkCreateImagePipeSurfaceFUCHSIA",  out vkCreateImagePipeSurfaceFUCHSIA_ptr);
			nativeLib.LoadFunction("vkCreateMetalSurfaceEXT",  out vkCreateMetalSurfaceEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFragmentShadingRatesKHR",  out vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr);
			nativeLib.LoadFunction("vkCmdSetFragmentShadingRateKHR",  out vkCmdSetFragmentShadingRateKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceToolPropertiesEXT",  out vkGetPhysicalDeviceToolPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV",  out vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV",  out vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModes2EXT",  out vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr);
			nativeLib.LoadFunction("vkAcquireFullScreenExclusiveModeEXT",  out vkAcquireFullScreenExclusiveModeEXT_ptr);
			nativeLib.LoadFunction("vkReleaseFullScreenExclusiveModeEXT",  out vkReleaseFullScreenExclusiveModeEXT_ptr);
			nativeLib.LoadFunction("vkCreateHeadlessSurfaceEXT",  out vkCreateHeadlessSurfaceEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetLineStippleEXT",  out vkCmdSetLineStippleEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetCullModeEXT",  out vkCmdSetCullModeEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetFrontFaceEXT",  out vkCmdSetFrontFaceEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetPrimitiveTopologyEXT",  out vkCmdSetPrimitiveTopologyEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetViewportWithCountEXT",  out vkCmdSetViewportWithCountEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetScissorWithCountEXT",  out vkCmdSetScissorWithCountEXT_ptr);
			nativeLib.LoadFunction("vkCmdBindVertexBuffers2EXT",  out vkCmdBindVertexBuffers2EXT_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthTestEnableEXT",  out vkCmdSetDepthTestEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthWriteEnableEXT",  out vkCmdSetDepthWriteEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthCompareOpEXT",  out vkCmdSetDepthCompareOpEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBoundsTestEnableEXT",  out vkCmdSetDepthBoundsTestEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilTestEnableEXT",  out vkCmdSetStencilTestEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilOpEXT",  out vkCmdSetStencilOpEXT_ptr);
			nativeLib.LoadFunction("vkCreateDeferredOperationKHR",  out vkCreateDeferredOperationKHR_ptr);
			nativeLib.LoadFunction("vkDestroyDeferredOperationKHR",  out vkDestroyDeferredOperationKHR_ptr);
			nativeLib.LoadFunction("vkGetDeferredOperationMaxConcurrencyKHR",  out vkGetDeferredOperationMaxConcurrencyKHR_ptr);
			nativeLib.LoadFunction("vkGetDeferredOperationResultKHR",  out vkGetDeferredOperationResultKHR_ptr);
			nativeLib.LoadFunction("vkDeferredOperationJoinKHR",  out vkDeferredOperationJoinKHR_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutablePropertiesKHR",  out vkGetPipelineExecutablePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutableStatisticsKHR",  out vkGetPipelineExecutableStatisticsKHR_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutableInternalRepresentationsKHR",  out vkGetPipelineExecutableInternalRepresentationsKHR_ptr);
			nativeLib.LoadFunction("vkGetGeneratedCommandsMemoryRequirementsNV",  out vkGetGeneratedCommandsMemoryRequirementsNV_ptr);
			nativeLib.LoadFunction("vkCmdPreprocessGeneratedCommandsNV",  out vkCmdPreprocessGeneratedCommandsNV_ptr);
			nativeLib.LoadFunction("vkCmdExecuteGeneratedCommandsNV",  out vkCmdExecuteGeneratedCommandsNV_ptr);
			nativeLib.LoadFunction("vkCmdBindPipelineShaderGroupNV",  out vkCmdBindPipelineShaderGroupNV_ptr);
			nativeLib.LoadFunction("vkCreateIndirectCommandsLayoutNV",  out vkCreateIndirectCommandsLayoutNV_ptr);
			nativeLib.LoadFunction("vkDestroyIndirectCommandsLayoutNV",  out vkDestroyIndirectCommandsLayoutNV_ptr);
			nativeLib.LoadFunction("vkCreatePrivateDataSlotEXT",  out vkCreatePrivateDataSlotEXT_ptr);
			nativeLib.LoadFunction("vkDestroyPrivateDataSlotEXT",  out vkDestroyPrivateDataSlotEXT_ptr);
			nativeLib.LoadFunction("vkSetPrivateDataEXT",  out vkSetPrivateDataEXT_ptr);
			nativeLib.LoadFunction("vkGetPrivateDataEXT",  out vkGetPrivateDataEXT_ptr);
			nativeLib.LoadFunction("vkCmdEncodeVideoKHR",  out vkCmdEncodeVideoKHR_ptr);
			nativeLib.LoadFunction("vkCmdSetEvent2KHR",  out vkCmdSetEvent2KHR_ptr);
			nativeLib.LoadFunction("vkCmdResetEvent2KHR",  out vkCmdResetEvent2KHR_ptr);
			nativeLib.LoadFunction("vkCmdWaitEvents2KHR",  out vkCmdWaitEvents2KHR_ptr);
			nativeLib.LoadFunction("vkCmdPipelineBarrier2KHR",  out vkCmdPipelineBarrier2KHR_ptr);
			nativeLib.LoadFunction("vkCmdWriteTimestamp2KHR",  out vkCmdWriteTimestamp2KHR_ptr);
			nativeLib.LoadFunction("vkQueueSubmit2KHR",  out vkQueueSubmit2KHR_ptr);
			nativeLib.LoadFunction("vkCmdSetFragmentShadingRateEnumNV",  out vkCmdSetFragmentShadingRateEnumNV_ptr);
			nativeLib.LoadFunction("vkCmdCopyBuffer2KHR",  out vkCmdCopyBuffer2KHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyImage2KHR",  out vkCmdCopyImage2KHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyBufferToImage2KHR",  out vkCmdCopyBufferToImage2KHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyImageToBuffer2KHR",  out vkCmdCopyImageToBuffer2KHR_ptr);
			nativeLib.LoadFunction("vkCmdBlitImage2KHR",  out vkCmdBlitImage2KHR_ptr);
			nativeLib.LoadFunction("vkCmdResolveImage2KHR",  out vkCmdResolveImage2KHR_ptr);
			nativeLib.LoadFunction("vkAcquireWinrtDisplayNV",  out vkAcquireWinrtDisplayNV_ptr);
			nativeLib.LoadFunction("vkGetWinrtDisplayNV",  out vkGetWinrtDisplayNV_ptr);
			nativeLib.LoadFunction("vkCreateDirectFBSurfaceEXT",  out vkCreateDirectFBSurfaceEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDirectFBPresentationSupportEXT",  out vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetVertexInputEXT",  out vkCmdSetVertexInputEXT_ptr);
			nativeLib.LoadFunction("vkGetMemoryZirconHandleFUCHSIA",  out vkGetMemoryZirconHandleFUCHSIA_ptr);
			nativeLib.LoadFunction("vkGetMemoryZirconHandlePropertiesFUCHSIA",  out vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr);
			nativeLib.LoadFunction("vkImportSemaphoreZirconHandleFUCHSIA",  out vkImportSemaphoreZirconHandleFUCHSIA_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreZirconHandleFUCHSIA",  out vkGetSemaphoreZirconHandleFUCHSIA_ptr);
			nativeLib.LoadFunction("vkCmdSetPatchControlPointsEXT",  out vkCmdSetPatchControlPointsEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetRasterizerDiscardEnableEXT",  out vkCmdSetRasterizerDiscardEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBiasEnableEXT",  out vkCmdSetDepthBiasEnableEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetLogicOpEXT",  out vkCmdSetLogicOpEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetPrimitiveRestartEnableEXT",  out vkCmdSetPrimitiveRestartEnableEXT_ptr);
			nativeLib.LoadFunction("vkCreateScreenSurfaceQNX",  out vkCreateScreenSurfaceQNX_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceScreenPresentationSupportQNX",  out vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr);
			nativeLib.LoadFunction("vkCmdSetColorWriteEnableEXT",  out vkCmdSetColorWriteEnableEXT_ptr);
		}
	}
}
