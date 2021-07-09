/*
 * my_hid.h
 *
 *  Created on: Jul 9, 2021
 *      Author: bill.wang
 */

#ifndef SRC_MY_HID_H_
#define SRC_MY_HID_H_

#include <stdbool.h>
#include "usbd_custom_hid_if.h"

extern uint8_t hid_out_report[64];
extern uint8_t hid_in_report[64];
extern bool is_hid_out_empty;

#endif /* SRC_MY_HID_H_ */
