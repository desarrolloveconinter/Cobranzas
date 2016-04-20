﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cobranzas.ServicioAvisos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioAvisos.IAvisosService")]
    public interface IAvisosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAvisosService/Avisos_Creados_lst", ReplyAction="http://tempuri.org/IAvisosService/Avisos_Creados_lstResponse")]
        Cobranzas.OT.otAviso[] Avisos_Creados_lst(int idOperador, System.DateTime FechaDesde, System.DateTime FechaHasta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAvisosService/Avisos_lst", ReplyAction="http://tempuri.org/IAvisosService/Avisos_lstResponse")]
        Cobranzas.OT.otAviso[] Avisos_lst(int idAviso, int idOperador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAvisosService/Avisos_ins", ReplyAction="http://tempuri.org/IAvisosService/Avisos_insResponse")]
        bool Avisos_ins(Cobranzas.OT.otAviso Aviso, int idOperador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAvisosService/Avisos_del", ReplyAction="http://tempuri.org/IAvisosService/Avisos_delResponse")]
        bool Avisos_del(int[] Avisos, string Comentario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAvisosServiceChannel : Cobranzas.ServicioAvisos.IAvisosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AvisosServiceClient : System.ServiceModel.ClientBase<Cobranzas.ServicioAvisos.IAvisosService>, Cobranzas.ServicioAvisos.IAvisosService {
        
        public AvisosServiceClient() {
        }
        
        public AvisosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AvisosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AvisosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AvisosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Cobranzas.OT.otAviso[] Avisos_Creados_lst(int idOperador, System.DateTime FechaDesde, System.DateTime FechaHasta) {
            return base.Channel.Avisos_Creados_lst(idOperador, FechaDesde, FechaHasta);
        }
        
        public Cobranzas.OT.otAviso[] Avisos_lst(int idAviso, int idOperador) {
            return base.Channel.Avisos_lst(idAviso, idOperador);
        }
        
        public bool Avisos_ins(Cobranzas.OT.otAviso Aviso, int idOperador) {
            return base.Channel.Avisos_ins(Aviso, idOperador);
        }
        
        public bool Avisos_del(int[] Avisos, string Comentario) {
            return base.Channel.Avisos_del(Avisos, Comentario);
        }
    }
}
