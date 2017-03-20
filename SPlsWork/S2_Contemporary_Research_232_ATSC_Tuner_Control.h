#ifndef __S2_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL_H__
#define __S2_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_VOLUME_UP_DIG_INPUT 0
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_VOLUME_DOWN_DIG_INPUT 1
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_KEYPAD_ENTER_SELECT_DIG_INPUT 2
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_KEYPAD_CLEAR_DIG_INPUT 3


/*
* ANALOG_INPUT
*/
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_PARAMETERIZED_UNIT_ID_ANALOG_INPUT 0
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_KEYPAD_TIMEOUT_ANALOG_INPUT 1


#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_DEMO_CHANNEL_PRESETS_TEXT_IN_BUFFER_INPUT 2
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_DEMO_CHANNEL_PRESETS_TEXT_IN_BUFFER_MAX_LEN 24
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __DEMO_CHANNEL_PRESETS_TEXT_IN, __S2_Contemporary_Research_232_ATSC_Tuner_Control_DEMO_CHANNEL_PRESETS_TEXT_IN_BUFFER_MAX_LEN );
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_PRESETS_TEXT_IN_BUFFER_INPUT 3
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_PRESETS_TEXT_IN_BUFFER_MAX_LEN 24
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __CHANNEL_PRESETS_TEXT_IN, __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_PRESETS_TEXT_IN_BUFFER_MAX_LEN );
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_KEY_IN_TEXT_BUFFER_INPUT 4
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_KEY_IN_TEXT_BUFFER_MAX_LEN 24
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __CHANNEL_KEY_IN_TEXT, __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_KEY_IN_TEXT_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_KEYPAD_TIMER_CLEAR_ANALOG_OUTPUT 2

#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_CHANNEL_KEY_OUT_TEXT_STRING_OUTPUT 0
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_TO_DEVICE_STRING_OUTPUT 1


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_SCHANNEL_STRING_MAX_LEN 24
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __SCHANNEL, __S2_Contemporary_Research_232_ATSC_Tuner_Control_SCHANNEL_STRING_MAX_LEN );
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_STEMP1_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __STEMP1, __S2_Contemporary_Research_232_ATSC_Tuner_Control_STEMP1_STRING_MAX_LEN );
#define __S2_Contemporary_Research_232_ATSC_Tuner_Control_SK_CHANNEL_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __SK_CHANNEL, __S2_Contemporary_Research_232_ATSC_Tuner_Control_SK_CHANNEL_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __IFLAG1;
   unsigned short __ICHANNEL;
   unsigned short __ITIMEOUT;
   unsigned short __ISEPARATOR;
   unsigned short __IVALID_LEFT;
   unsigned short __IVALID_RIGHT;
   unsigned short __IINVALID;
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __SCHANNEL );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __STEMP1 );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __SK_CHANNEL );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __DEMO_CHANNEL_PRESETS_TEXT_IN );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __CHANNEL_PRESETS_TEXT_IN );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control, __CHANNEL_KEY_IN_TEXT );
};

START_NVRAM_VAR_STRUCT( S2_Contemporary_Research_232_ATSC_Tuner_Control )
{
};



#endif //__S2_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL_H__

