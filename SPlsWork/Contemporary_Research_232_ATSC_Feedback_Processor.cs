using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_CONTEMPORARY_RESEARCH_232_ATSC_FEEDBACK_PROCESSOR
{
    public class CrestronModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_FEEDBACK_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogInput PARAMETERIZED_UNIT_ID;
        Crestron.Logos.SplusObjects.AnalogOutput POWER_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIO_STATUS_POWER_ANALOG;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_ACTUAL_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_MUTE_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CC_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CC_TYPE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_DETECT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AV_DETECT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput LABEL_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput IR_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput DIGITAL_CC_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_MUTE_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput INPUT_RF_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput RF_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput RECEIVED_RESOLUTION_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_RESOLUTION_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_SETTING_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput F_PANEL_LOCK_ANALOG;
        ushort ITEMP = 0;
        ushort IFLAG1 = 0;
        ushort CH_SRC_MAJ_CH_ANALOG = 0;
        ushort CH_SRC_MIN_CH_ANALOG = 0;
        CrestronString STEMP;
        CrestronString STEMP1;
        CrestronString SUNIT_RESPONSE_T;
        CrestronString SUNIT_RESPONSE_V;
        CrestronString SUNIT_RESPONSE_S;
        CrestronString SUNIT_RESPONSE_Q;
        object FROM_DEVICE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 79;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 81;
                    IFLAG1 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 82;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "<" , FROM_DEVICE ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 84;
                        STEMP  .UpdateValue ( Functions.Gather ( "\u000A" , FROM_DEVICE )  ) ; 
                        __context__.SourceCodeLine = 85;
                        SUNIT_RESPONSE_T  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "T"  ) ; 
                        __context__.SourceCodeLine = 86;
                        SUNIT_RESPONSE_V  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "V"  ) ; 
                        __context__.SourceCodeLine = 87;
                        SUNIT_RESPONSE_S  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "S"  ) ; 
                        __context__.SourceCodeLine = 88;
                        SUNIT_RESPONSE_Q  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "Q"  ) ; 
                        __context__.SourceCodeLine = 89;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_T , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 91;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 4 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 92;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 93;
                                POWER_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 94;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 95;
                                POWER_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 97;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 5 ) ,  (int) ( 3 ) )  ) ; 
                            __context__.SourceCodeLine = 98;
                            CH_SRC_MAJ_CH_ANALOG = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 100;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 8 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 101;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 103;
                                VIDEO_MUTE_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 107;
                                VIDEO_MUTE_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 110;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 111;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 113;
                                INPUT_RF_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 117;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 10 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 118;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "A" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 120;
                                RF_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 122;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "C" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 124;
                                RF_STATUS_ANALOG  .Value = (ushort) ( 2 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 128;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 11 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 129;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 131;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 133;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 135;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 137;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 139;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 141;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 143;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 145;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "N" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 147;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 4 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 151;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 12 ) ,  (int) ( 3 ) )  ) ; 
                            __context__.SourceCodeLine = 152;
                            CH_SRC_MIN_CH_ANALOG = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 153;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CH_SRC_MIN_CH_ANALOG > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 154;
                                CHANNEL_TEXT  .UpdateValue ( Functions.ItoA (  (int) ( CH_SRC_MAJ_CH_ANALOG ) ) + "-" + Functions.ItoA (  (int) ( CH_SRC_MIN_CH_ANALOG ) )  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 156;
                                CHANNEL_TEXT  .UpdateValue ( Functions.ItoA (  (int) ( CH_SRC_MAJ_CH_ANALOG ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 159;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 160;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 164;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_V , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 166;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 4 ) ,  (int) ( 1 ) )  ) ; 
                                __context__.SourceCodeLine = 168;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 169;
                                    AUDIO_STATUS_POWER_ANALOG  .Value = (ushort) ( 1 ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 170;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 171;
                                    AUDIO_STATUS_POWER_ANALOG  .Value = (ushort) ( 0 ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 173;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                                __context__.SourceCodeLine = 174;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 176;
                                    VOLUME_MUTE_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 178;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 180;
                                    VOLUME_MUTE_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 186;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( 3 ) )  ) ; 
                                __context__.SourceCodeLine = 187;
                                VOLUME_ACTUAL_ANALOG  .Value = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 189;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 190;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 192;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_S , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 195;
                                    F_PANEL_LOCK_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 6 ) , (int)( 1 ) ) ) ) ; 
                                    __context__.SourceCodeLine = 197;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 10 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 198;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 200;
                                        OUTPUT_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 203;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 205;
                                        OUTPUT_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 208;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 11 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 209;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 211;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 213;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 215;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 217;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 219;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 221;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 223;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 226;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 12 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 227;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 229;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 231;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 233;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 235;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 237;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 239;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 241;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 244;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 245;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 247;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_Q , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 250;
                                        CC_STATUS_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 4 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 252;
                                        CC_TYPE_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 5 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 254;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 6 ) ,  (int) ( 1 ) )  ) ; 
                                        __context__.SourceCodeLine = 255;
                                        VIDEO_DETECT_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 6 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 257;
                                        AV_DETECT_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 7 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 259;
                                        LABEL_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 8 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 261;
                                        IR_STATUS_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 9 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 263;
                                        DIGITAL_CC_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 11 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 264;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 265;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 82;
                        } 
                    
                    __context__.SourceCodeLine = 269;
                    IFLAG1 = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 279;
            IFLAG1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 280;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 281;
            STEMP1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 282;
            ITEMP = (ushort) ( 100 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        SUNIT_RESPONSE_T  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_V  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_Q  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        
        PARAMETERIZED_UNIT_ID = new Crestron.Logos.SplusObjects.AnalogInput( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, PARAMETERIZED_UNIT_ID );
        
        POWER_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( POWER_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( POWER_STATUS_ANALOG__AnalogSerialOutput__, POWER_STATUS_ANALOG );
        
        AUDIO_STATUS_POWER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__, AUDIO_STATUS_POWER_ANALOG );
        
        VOLUME_ACTUAL_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__, VOLUME_ACTUAL_ANALOG );
        
        VOLUME_MUTE_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__, VOLUME_MUTE_STATUS_ANALOG );
        
        CC_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( CC_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CC_STATUS_ANALOG__AnalogSerialOutput__, CC_STATUS_ANALOG );
        
        CC_TYPE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( CC_TYPE_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CC_TYPE_ANALOG__AnalogSerialOutput__, CC_TYPE_ANALOG );
        
        VIDEO_DETECT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_DETECT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VIDEO_DETECT_ANALOG__AnalogSerialOutput__, VIDEO_DETECT_ANALOG );
        
        AV_DETECT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AV_DETECT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AV_DETECT_ANALOG__AnalogSerialOutput__, AV_DETECT_ANALOG );
        
        LABEL_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( LABEL_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LABEL_ANALOG__AnalogSerialOutput__, LABEL_ANALOG );
        
        IR_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( IR_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( IR_STATUS_ANALOG__AnalogSerialOutput__, IR_STATUS_ANALOG );
        
        DIGITAL_CC_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( DIGITAL_CC_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( DIGITAL_CC_ANALOG__AnalogSerialOutput__, DIGITAL_CC_ANALOG );
        
        VIDEO_MUTE_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__, VIDEO_MUTE_STATUS_ANALOG );
        
        INPUT_RF_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( INPUT_RF_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( INPUT_RF_ANALOG__AnalogSerialOutput__, INPUT_RF_ANALOG );
        
        RF_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( RF_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( RF_STATUS_ANALOG__AnalogSerialOutput__, RF_STATUS_ANALOG );
        
        RECEIVED_RESOLUTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__, RECEIVED_RESOLUTION_ANALOG );
        
        OUTPUT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_ANALOG__AnalogSerialOutput__, OUTPUT_ANALOG );
        
        OUTPUT_RESOLUTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__, OUTPUT_RESOLUTION_ANALOG );
        
        OUTPUT_SETTING_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_SETTING_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_SETTING_ANALOG__AnalogSerialOutput__, OUTPUT_SETTING_ANALOG );
        
        F_PANEL_LOCK_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( F_PANEL_LOCK_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( F_PANEL_LOCK_ANALOG__AnalogSerialOutput__, F_PANEL_LOCK_ANALOG );
        
        CHANNEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_TEXT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CHANNEL_TEXT__AnalogSerialOutput__, CHANNEL_TEXT );
        
        FROM_DEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__AnalogSerialInput__, 200, this );
        m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
        
        
        FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_FEEDBACK_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__AnalogSerialInput__ = 0;
    const uint PARAMETERIZED_UNIT_ID__AnalogSerialInput__ = 1;
    const uint POWER_STATUS_ANALOG__AnalogSerialOutput__ = 0;
    const uint AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__ = 1;
    const uint CHANNEL_TEXT__AnalogSerialOutput__ = 2;
    const uint VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__ = 3;
    const uint VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__ = 4;
    const uint CC_STATUS_ANALOG__AnalogSerialOutput__ = 5;
    const uint CC_TYPE_ANALOG__AnalogSerialOutput__ = 6;
    const uint VIDEO_DETECT_ANALOG__AnalogSerialOutput__ = 7;
    const uint AV_DETECT_ANALOG__AnalogSerialOutput__ = 8;
    const uint LABEL_ANALOG__AnalogSerialOutput__ = 9;
    const uint IR_STATUS_ANALOG__AnalogSerialOutput__ = 10;
    const uint DIGITAL_CC_ANALOG__AnalogSerialOutput__ = 11;
    const uint VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__ = 12;
    const uint INPUT_RF_ANALOG__AnalogSerialOutput__ = 13;
    const uint RF_STATUS_ANALOG__AnalogSerialOutput__ = 14;
    const uint RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__ = 15;
    const uint OUTPUT_ANALOG__AnalogSerialOutput__ = 16;
    const uint OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__ = 17;
    const uint OUTPUT_SETTING_ANALOG__AnalogSerialOutput__ = 18;
    const uint F_PANEL_LOCK_ANALOG__AnalogSerialOutput__ = 19;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
