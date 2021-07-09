/* USER CODE BEGIN Header */
/**
 ******************************************************************************
 * File Name          : freertos.c
 * Description        : Code for freertos applications
 ******************************************************************************
 * @attention
 *
 * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
 * All rights reserved.</center></h2>
 *
 * This software component is licensed by ST under Ultimate Liberty license
 * SLA0044, the "License"; You may not use this file except in compliance with
 * the License. You may obtain a copy of the License at:
 *                             www.st.com/SLA0044
 *
 ******************************************************************************
 */
/* USER CODE END Header */

/* Includes ------------------------------------------------------------------*/
#include "FreeRTOS.h"
#include "task.h"
#include "main.h"
#include "cmsis_os.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
//#include <stdio.h>
#include <string.h>
#include "my_hid.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */

/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
/* USER CODE BEGIN Variables */

/* USER CODE END Variables */
/* Definitions for console */
osThreadId_t consoleHandle;
const osThreadAttr_t console_attributes =
{ .name = "console", .stack_size = 512 * 4, .priority =
		(osPriority_t) osPriorityNormal, };
/* Definitions for button */
osThreadId_t buttonHandle;
const osThreadAttr_t button_attributes =
{ .name = "button", .stack_size = 128 * 4, .priority =
		(osPriority_t) osPriorityRealtime, };
/* Definitions for buzzer */
osThreadId_t buzzerHandle;
const osThreadAttr_t buzzer_attributes =
{ .name = "buzzer", .stack_size = 128 * 4, .priority =
		(osPriority_t) osPriorityLow, };
/* Definitions for timer0 */
osThreadId_t timer0Handle;
const osThreadAttr_t timer0_attributes =
{ .name = "timer0", .stack_size = 128 * 4, .priority =
		(osPriority_t) osPriorityNormal, };
/* Definitions for cdc_tx_mutex */
osMutexId_t cdc_tx_mutexHandle;
const osMutexAttr_t cdc_tx_mutex_attributes =
{ .name = "cdc_tx_mutex" };
/* Definitions for uart_tx_mutex */
osMutexId_t uart_tx_mutexHandle;
const osMutexAttr_t uart_tx_mutex_attributes =
{ .name = "uart_tx_mutex" };
/* Definitions for cdc_rx_mutex */
osMutexId_t cdc_rx_mutexHandle;
const osMutexAttr_t cdc_rx_mutex_attributes =
{ .name = "cdc_rx_mutex" };
/* Definitions for pwm_set_mutex */
osMutexId_t pwm_set_mutexHandle;
const osMutexAttr_t pwm_set_mutex_attributes =
{ .name = "pwm_set_mutex" };
/* Definitions for rtos_event */
osEventFlagsId_t rtos_eventHandle;
const osEventFlagsAttr_t rtos_event_attributes =
{ .name = "rtos_event" };

/* Private function prototypes -----------------------------------------------*/
/* USER CODE BEGIN FunctionPrototypes */

/* USER CODE END FunctionPrototypes */

void process_console(void *argument);
void process_button(void *argument);
void process_buzzer(void *argument);
void process_timer0(void *argument);

extern void MX_USB_DEVICE_Init(void);
void MX_FREERTOS_Init(void); /* (MISRA C 2004 rule 8.1) */

/**
 * @brief  FreeRTOS initialization
 * @param  None
 * @retval None
 */
void MX_FREERTOS_Init(void)
{
	/* USER CODE BEGIN Init */

	/* USER CODE END Init */
	/* Create the mutex(es) */
	/* creation of cdc_tx_mutex */
	cdc_tx_mutexHandle = osMutexNew(&cdc_tx_mutex_attributes);

	/* creation of uart_tx_mutex */
	uart_tx_mutexHandle = osMutexNew(&uart_tx_mutex_attributes);

	/* creation of cdc_rx_mutex */
	cdc_rx_mutexHandle = osMutexNew(&cdc_rx_mutex_attributes);

	/* creation of pwm_set_mutex */
	pwm_set_mutexHandle = osMutexNew(&pwm_set_mutex_attributes);

	/* USER CODE BEGIN RTOS_MUTEX */
	/* add mutexes, ... */
	/* USER CODE END RTOS_MUTEX */

	/* USER CODE BEGIN RTOS_SEMAPHORES */
	/* add semaphores, ... */
	/* USER CODE END RTOS_SEMAPHORES */

	/* USER CODE BEGIN RTOS_TIMERS */
	/* start timers, add new ones, ... */
	/* USER CODE END RTOS_TIMERS */

	/* USER CODE BEGIN RTOS_QUEUES */
	/* add queues, ... */
	/* USER CODE END RTOS_QUEUES */

	/* Create the thread(s) */
	/* creation of console */
	consoleHandle = osThreadNew(process_console, NULL, &console_attributes);

	/* creation of button */
	buttonHandle = osThreadNew(process_button, NULL, &button_attributes);

	/* creation of buzzer */
	buzzerHandle = osThreadNew(process_buzzer, NULL, &buzzer_attributes);

	/* creation of timer0 */
	timer0Handle = osThreadNew(process_timer0, NULL, &timer0_attributes);

	/* USER CODE BEGIN RTOS_THREADS */
	/* add threads, ... */
	/* USER CODE END RTOS_THREADS */

	/* creation of rtos_event */
	rtos_eventHandle = osEventFlagsNew(&rtos_event_attributes);

	/* USER CODE BEGIN RTOS_EVENTS */
	/* add events, ... */
	/* USER CODE END RTOS_EVENTS */

}

/* USER CODE BEGIN Header_process_console */
/**
 * @brief  Function implementing the console thread.
 * @param  argument: Not used
 * @retval None
 */
/* USER CODE END Header_process_console */
void process_console(void *argument)
{
	/* init code for USB_DEVICE */
	MX_USB_DEVICE_Init();
	/* USER CODE BEGIN process_console */
	/* Infinite loop */
	for (;;)
	{
		if (is_hid_out_empty == false)
		{
			memcpy(hid_in_report, hid_out_report, 64);
			for (int i = 0; i < 64; i++)
			{
				hid_in_report[i] = hid_out_report[i];
			}
			USBD_CUSTOM_HID_SendReport_FS(hid_in_report, 64);
			is_hid_out_empty = true;
		}

		osDelay(1);
	}
	/* USER CODE END process_console */
}

/* USER CODE BEGIN Header_process_button */
/**
 * @brief Function implementing the button thread.
 * @param argument: Not used
 * @retval None
 */
/* USER CODE END Header_process_button */
void process_button(void *argument)
{
	/* USER CODE BEGIN process_button */
	/* Infinite loop */
	for (;;)
	{
		osDelay(1);
	}
	/* USER CODE END process_button */
}

/* USER CODE BEGIN Header_process_buzzer */
/**
 * @brief Function implementing the buzzer thread.
 * @param argument: Not used
 * @retval None
 */
/* USER CODE END Header_process_buzzer */
void process_buzzer(void *argument)
{
	/* USER CODE BEGIN process_buzzer */
	/* Infinite loop */
	for (;;)
	{
		osDelay(1);
	}
	/* USER CODE END process_buzzer */
}

/* USER CODE BEGIN Header_process_timer0 */
/**
 * @brief Function implementing the timer0 thread.
 * @param argument: Not used
 * @retval None
 */
/* USER CODE END Header_process_timer0 */
void process_timer0(void *argument)
{
	/* USER CODE BEGIN process_timer0 */
	/* Infinite loop */
	for (;;)
	{
		osDelay(1);
	}
	/* USER CODE END process_timer0 */
}

/* Private application code --------------------------------------------------*/
/* USER CODE BEGIN Application */

/* USER CODE END Application */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
