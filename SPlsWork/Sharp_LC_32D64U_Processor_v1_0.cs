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

namespace CrestronModule_SHARP_LC_32D64U_PROCESSOR_V1_0
{
    public class CrestronModuleClass_SHARP_LC_32D64U_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput AIR;
        Crestron.Logos.SplusObjects.DigitalInput CABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KP;
        Crestron.Logos.SplusObjects.StringOutput NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort ALOC = 0;
        CrestronString SNUMBER;
        CrestronString SCHANNELF;
        CrestronString SCHANNELR;
        object KP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 124;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 127;
                            MakeString ( SNUMBER , "{0}0", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 129;
                            MakeString ( SNUMBER , "{0}1", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 131;
                            MakeString ( SNUMBER , "{0}2", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            {
                            __context__.SourceCodeLine = 133;
                            MakeString ( SNUMBER , "{0}3", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            {
                            __context__.SourceCodeLine = 135;
                            MakeString ( SNUMBER , "{0}4", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                            {
                            __context__.SourceCodeLine = 137;
                            MakeString ( SNUMBER , "{0}5", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                            {
                            __context__.SourceCodeLine = 139;
                            MakeString ( SNUMBER , "{0}6", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                            {
                            __context__.SourceCodeLine = 141;
                            MakeString ( SNUMBER , "{0}7", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                            {
                            __context__.SourceCodeLine = 143;
                            MakeString ( SNUMBER , "{0}8", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                            {
                            __context__.SourceCodeLine = 145;
                            MakeString ( SNUMBER , "{0}9", SNUMBER ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 148;
                            ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
                            __context__.SourceCodeLine = 149;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 151;
                                MakeString ( SNUMBER , "{0}.", SNUMBER ) ; 
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 156;
                            Functions.ClearBuffer ( SNUMBER ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 13) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 160;
                            ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
                            __context__.SourceCodeLine = 161;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 163;
                                if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 165;
                                    MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                                    __context__.SourceCodeLine = 166;
                                    MakeString ( SCHANNELR , "{0:d2}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                                    __context__.SourceCodeLine = 167;
                                    MakeString ( TO_DEVICE__DOLLAR__ , "DA2P{0}{1}\r", SCHANNELF , SCHANNELR ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 169;
                                    if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 171;
                                        MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                                        __context__.SourceCodeLine = 172;
                                        MakeString ( SCHANNELR , "{0:d3}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                                        __context__.SourceCodeLine = 173;
                                        MakeString ( TO_DEVICE__DOLLAR__ , "DC2U{0} \rDC2L{1} \r", SCHANNELF , SCHANNELR ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 178;
                                if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 180;
                                    MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( SNUMBER )) ; 
                                    __context__.SourceCodeLine = 181;
                                    MakeString ( TO_DEVICE__DOLLAR__ , "DCCH{0}  \r", SCHANNELF ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 183;
                                    if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 185;
                                        MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( SNUMBER )) ; 
                                        __context__.SourceCodeLine = 186;
                                        MakeString ( TO_DEVICE__DOLLAR__ , "DCCH{0} \r", SCHANNELF ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 189;
                            Functions.ClearBuffer ( SNUMBER ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 192;
                NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
                
                
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
            
            __context__.SourceCodeLine = 203;
            Functions.ClearBuffer ( SNUMBER ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        SCHANNELF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
        SCHANNELR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
        
        AIR = new Crestron.Logos.SplusObjects.DigitalInput( AIR__DigitalInput__, this );
        m_DigitalInputList.Add( AIR__DigitalInput__, AIR );
        
        CABLE = new Crestron.Logos.SplusObjects.DigitalInput( CABLE__DigitalInput__, this );
        m_DigitalInputList.Add( CABLE__DigitalInput__, CABLE );
        
        KP = new InOutArray<DigitalInput>( 13, this );
        for( uint i = 0; i < 13; i++ )
        {
            KP[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KP__DigitalInput__ + i, KP__DigitalInput__, this );
            m_DigitalInputList.Add( KP__DigitalInput__ + i, KP[i+1] );
        }
        
        NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( NUMBER__DOLLAR____AnalogSerialOutput__, NUMBER__DOLLAR__ );
        
        TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
        
        
        for( uint i = 0; i < 13; i++ )
            KP[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_OnPush_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_SHARP_LC_32D64U_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint AIR__DigitalInput__ = 0;
    const uint CABLE__DigitalInput__ = 1;
    const uint KP__DigitalInput__ = 2;
    const uint NUMBER__DOLLAR____AnalogSerialOutput__ = 0;
    const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 1;
    
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
