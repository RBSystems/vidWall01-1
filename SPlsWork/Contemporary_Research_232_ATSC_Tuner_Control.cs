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

namespace CrestronModule_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL
{
    public class CrestronModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput PARAMETERIZED_UNIT_ID;
        Crestron.Logos.SplusObjects.AnalogInput KEYPAD_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_ENTER_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_CLEAR;
        Crestron.Logos.SplusObjects.BufferInput DEMO_CHANNEL_PRESETS_TEXT_IN;
        Crestron.Logos.SplusObjects.BufferInput CHANNEL_PRESETS_TEXT_IN;
        Crestron.Logos.SplusObjects.BufferInput CHANNEL_KEY_IN_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_KEY_OUT_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput KEYPAD_TIMER_CLEAR;
        ushort IFLAG1 = 0;
        ushort ICHANNEL = 0;
        ushort ITIMEOUT = 0;
        ushort ISEPARATOR = 0;
        ushort IVALID_LEFT = 0;
        ushort IVALID_RIGHT = 0;
        ushort IINVALID = 0;
        CrestronString SCHANNEL;
        CrestronString STEMP1;
        CrestronString SK_CHANNEL;
        object VOLUME_UP_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 58;
                Functions.Delay (  (int) ( 25 ) ) ; 
                __context__.SourceCodeLine = 59;
                TO_DEVICE  .UpdateValue ( ">VV\r\n"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KEYPAD_ENTER_SELECT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 64;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( SK_CHANNEL ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SK_CHANNEL ) <= 7 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 66;
                SK_CHANNEL  .UpdateValue ( ">" + Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "TC=" + SK_CHANNEL + "\r\n"  ) ; 
                __context__.SourceCodeLine = 67;
                TO_DEVICE  .UpdateValue ( SK_CHANNEL  ) ; 
                __context__.SourceCodeLine = 68;
                SK_CHANNEL  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 69;
                CHANNEL_KEY_IN_TEXT  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 70;
                CHANNEL_KEY_OUT_TEXT  .UpdateValue ( SK_CHANNEL  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEYPAD_CLEAR_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 77;
        SK_CHANNEL  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 78;
        CHANNEL_KEY_IN_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 79;
        CHANNEL_KEY_OUT_TEXT  .UpdateValue ( SK_CHANNEL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_TIMEOUT_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        ITIMEOUT = (ushort) ( KEYPAD_TIMEOUT  .UshortValue ) ; 
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEOUT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( SK_CHANNEL ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SK_CHANNEL ) <= 7 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 89;
                SK_CHANNEL  .UpdateValue ( ">" + Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "TC=" + SK_CHANNEL + "\r\n"  ) ; 
                __context__.SourceCodeLine = 90;
                TO_DEVICE  .UpdateValue ( SK_CHANNEL  ) ; 
                __context__.SourceCodeLine = 91;
                SK_CHANNEL  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 92;
                CHANNEL_KEY_IN_TEXT  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 93;
                CHANNEL_KEY_OUT_TEXT  .UpdateValue ( SK_CHANNEL  ) ; 
                __context__.SourceCodeLine = 94;
                ITIMEOUT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 95;
                KEYPAD_TIMER_CLEAR  .Value = (ushort) ( ITIMEOUT ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNEL_KEY_IN_TEXT_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 106;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 107;
            SK_CHANNEL  .UpdateValue ( SK_CHANNEL + CHANNEL_KEY_IN_TEXT  ) ; 
            __context__.SourceCodeLine = 108;
            CHANNEL_KEY_OUT_TEXT  .UpdateValue ( SK_CHANNEL  ) ; 
            __context__.SourceCodeLine = 110;
            ISEPARATOR = (ushort) ( Functions.Find( "-" , SK_CHANNEL ) ) ; 
            __context__.SourceCodeLine = 111;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISEPARATOR == 0))  ) ) 
                {
                __context__.SourceCodeLine = 111;
                ISEPARATOR = (ushort) ( Functions.Find( ":" , SK_CHANNEL ) ) ; 
                }
            
            __context__.SourceCodeLine = 112;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISEPARATOR > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 114;
                IVALID_LEFT = (ushort) ( Functions.Atoi( Functions.Left( SK_CHANNEL , (int)( (ISEPARATOR - 1) ) ) ) ) ; 
                __context__.SourceCodeLine = 115;
                IVALID_RIGHT = (ushort) ( Functions.Atoi( Functions.Right( SK_CHANNEL , (int)( (Functions.Length( SK_CHANNEL ) - ISEPARATOR) ) ) ) ) ; 
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IVALID_LEFT > 999 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( IVALID_RIGHT > 999 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 118;
                    IINVALID = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 122;
                    IINVALID = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 128;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( SK_CHANNEL ) > 999 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 128;
                    IINVALID = (ushort) ( 1 ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 131;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( KEYPAD_ENTER_SELECT  .Value ) || Functions.TestForTrue ( KEYPAD_CLEAR  .Value )) ) ) || Functions.TestForTrue ( IINVALID )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 132;
                SK_CHANNEL  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 133;
                CHANNEL_KEY_OUT_TEXT  .UpdateValue ( SK_CHANNEL  ) ; 
                __context__.SourceCodeLine = 134;
                CHANNEL_KEY_IN_TEXT  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 135;
                IINVALID = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 137;
            IFLAG1 = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 140;
        CHANNEL_KEY_IN_TEXT  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNEL_PRESETS_TEXT_IN_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 152;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 153;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "-" , CHANNEL_PRESETS_TEXT_IN ) > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( ":" , CHANNEL_PRESETS_TEXT_IN ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "-" , CHANNEL_PRESETS_TEXT_IN ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( ":" , CHANNEL_PRESETS_TEXT_IN ) == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( CHANNEL_PRESETS_TEXT_IN ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( CHANNEL_PRESETS_TEXT_IN ) < 99 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 162;
                STEMP1  .UpdateValue ( Functions.Gather ( "\u000A" , CHANNEL_PRESETS_TEXT_IN )  ) ; 
                __context__.SourceCodeLine = 165;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( STEMP1 ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( STEMP1 ) < 9999 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 167;
                    STEMP1  .UpdateValue ( Functions.Left ( STEMP1 ,  (int) ( (Functions.Length( STEMP1 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 168;
                    SCHANNEL  .UpdateValue ( ">" + Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "TC=" + STEMP1 + "\r\n"  ) ; 
                    __context__.SourceCodeLine = 169;
                    TO_DEVICE  .UpdateValue ( SCHANNEL  ) ; 
                    __context__.SourceCodeLine = 171;
                    Functions.ClearBuffer ( CHANNEL_PRESETS_TEXT_IN ) ; 
                    } 
                
                __context__.SourceCodeLine = 153;
                } 
            
            __context__.SourceCodeLine = 175;
            IFLAG1 = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEMO_CHANNEL_PRESETS_TEXT_IN_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 181;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 183;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 184;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "-" , DEMO_CHANNEL_PRESETS_TEXT_IN ) > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( ":" , DEMO_CHANNEL_PRESETS_TEXT_IN ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "-" , DEMO_CHANNEL_PRESETS_TEXT_IN ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( ":" , DEMO_CHANNEL_PRESETS_TEXT_IN ) == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( DEMO_CHANNEL_PRESETS_TEXT_IN ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( DEMO_CHANNEL_PRESETS_TEXT_IN ) < 99 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 193;
                STEMP1  .UpdateValue ( Functions.Gather ( "\u000A" , DEMO_CHANNEL_PRESETS_TEXT_IN )  ) ; 
                __context__.SourceCodeLine = 196;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( STEMP1 ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( STEMP1 ) < 9999 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 198;
                    STEMP1  .UpdateValue ( Functions.Left ( STEMP1 ,  (int) ( (Functions.Length( STEMP1 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 199;
                    SCHANNEL  .UpdateValue ( ">" + Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "TC=" + STEMP1 + "\r\n"  ) ; 
                    __context__.SourceCodeLine = 200;
                    TO_DEVICE  .UpdateValue ( SCHANNEL  ) ; 
                    __context__.SourceCodeLine = 202;
                    Functions.ClearBuffer ( DEMO_CHANNEL_PRESETS_TEXT_IN ) ; 
                    } 
                
                __context__.SourceCodeLine = 184;
                } 
            
            __context__.SourceCodeLine = 206;
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
        
        __context__.SourceCodeLine = 218;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 219;
        STEMP1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 220;
        SK_CHANNEL  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 221;
        Functions.ClearBuffer ( CHANNEL_KEY_IN_TEXT ) ; 
        __context__.SourceCodeLine = 222;
        Functions.ClearBuffer ( DEMO_CHANNEL_PRESETS_TEXT_IN ) ; 
        __context__.SourceCodeLine = 223;
        Functions.ClearBuffer ( CHANNEL_PRESETS_TEXT_IN ) ; 
        __context__.SourceCodeLine = 224;
        CHANNEL_KEY_OUT_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 225;
        ITIMEOUT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 226;
        IINVALID = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    SCHANNEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SK_CHANNEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    KEYPAD_ENTER_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_ENTER_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_ENTER_SELECT__DigitalInput__, KEYPAD_ENTER_SELECT );
    
    KEYPAD_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_CLEAR__DigitalInput__, KEYPAD_CLEAR );
    
    PARAMETERIZED_UNIT_ID = new Crestron.Logos.SplusObjects.AnalogInput( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, PARAMETERIZED_UNIT_ID );
    
    KEYPAD_TIMEOUT = new Crestron.Logos.SplusObjects.AnalogInput( KEYPAD_TIMEOUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( KEYPAD_TIMEOUT__AnalogSerialInput__, KEYPAD_TIMEOUT );
    
    KEYPAD_TIMER_CLEAR = new Crestron.Logos.SplusObjects.AnalogOutput( KEYPAD_TIMER_CLEAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( KEYPAD_TIMER_CLEAR__AnalogSerialOutput__, KEYPAD_TIMER_CLEAR );
    
    CHANNEL_KEY_OUT_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_KEY_OUT_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHANNEL_KEY_OUT_TEXT__AnalogSerialOutput__, CHANNEL_KEY_OUT_TEXT );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    DEMO_CHANNEL_PRESETS_TEXT_IN = new Crestron.Logos.SplusObjects.BufferInput( DEMO_CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__, 24, this );
    m_StringInputList.Add( DEMO_CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__, DEMO_CHANNEL_PRESETS_TEXT_IN );
    
    CHANNEL_PRESETS_TEXT_IN = new Crestron.Logos.SplusObjects.BufferInput( CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__, 24, this );
    m_StringInputList.Add( CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__, CHANNEL_PRESETS_TEXT_IN );
    
    CHANNEL_KEY_IN_TEXT = new Crestron.Logos.SplusObjects.BufferInput( CHANNEL_KEY_IN_TEXT__AnalogSerialInput__, 24, this );
    m_StringInputList.Add( CHANNEL_KEY_IN_TEXT__AnalogSerialInput__, CHANNEL_KEY_IN_TEXT );
    
    
    VOLUME_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnRelease_0, false ) );
    VOLUME_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnRelease_0, false ) );
    KEYPAD_ENTER_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_ENTER_SELECT_OnPush_1, false ) );
    KEYPAD_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_CLEAR_OnPush_2, false ) );
    KEYPAD_TIMEOUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( KEYPAD_TIMEOUT_OnChange_3, false ) );
    CHANNEL_KEY_IN_TEXT.OnSerialChange.Add( new InputChangeHandlerWrapper( CHANNEL_KEY_IN_TEXT_OnChange_4, false ) );
    CHANNEL_PRESETS_TEXT_IN.OnSerialChange.Add( new InputChangeHandlerWrapper( CHANNEL_PRESETS_TEXT_IN_OnChange_5, false ) );
    DEMO_CHANNEL_PRESETS_TEXT_IN.OnSerialChange.Add( new InputChangeHandlerWrapper( DEMO_CHANNEL_PRESETS_TEXT_IN_OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_TUNER_CONTROL ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PARAMETERIZED_UNIT_ID__AnalogSerialInput__ = 0;
const uint KEYPAD_TIMEOUT__AnalogSerialInput__ = 1;
const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DOWN__DigitalInput__ = 1;
const uint KEYPAD_ENTER_SELECT__DigitalInput__ = 2;
const uint KEYPAD_CLEAR__DigitalInput__ = 3;
const uint DEMO_CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__ = 2;
const uint CHANNEL_PRESETS_TEXT_IN__AnalogSerialInput__ = 3;
const uint CHANNEL_KEY_IN_TEXT__AnalogSerialInput__ = 4;
const uint CHANNEL_KEY_OUT_TEXT__AnalogSerialOutput__ = 0;
const uint TO_DEVICE__AnalogSerialOutput__ = 1;
const uint KEYPAD_TIMER_CLEAR__AnalogSerialOutput__ = 2;

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
