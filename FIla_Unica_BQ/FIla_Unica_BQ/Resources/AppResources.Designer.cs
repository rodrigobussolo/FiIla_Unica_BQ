﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fila_Unica_BQ.Resources {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fila_Unica_BQ.Resources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a FILA ÚNICA - Brusque.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a by Rodrigo Bussolo.
        /// </summary>
        internal static string Desenvolvedor {
            get {
                return ResourceManager.GetString("Desenvolvedor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Para efetuar a inscrição do aluno, vá a uma unidade escolar do município portanto os seguintes documentos:
        ///
        ///• CPF do candidato;
        ///• Certidão do candidato;
        ///• Comprovante de residência atualizado com o nome dos pais e/ou responsável;
        ///• Comprovante de renda atualizado;
        ///• Documento oficial do Pai/Mãe ou Responsável com foto..
        /// </summary>
        internal static string Documentos {
            get {
                return ResourceManager.GetString("Documentos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a rodrigobussolo@gmail.com.
        /// </summary>
        internal static string Email_Contato {
            get {
                return ResourceManager.GetString("Email_Contato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a O aplicativo Fila Única Brusque foi desenvolvido para auxiliar na consulta e detalhamento da posição em que um candidato a vagas para as creches do município de Brusque - SC, se encontram.
        ///	
        ///Atualmente existe um site do município onde os pais podem verificar o posicionamento geral de seu filho na fila de espera, porém, este posicionamento geral não é suficiente, considerando que:
        ///
        ///• Cada candidato pode se cadastrar para vagas em até 3 creches,
        ///• Cada uma destas creches tem certa quantidade de candidato [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string Sobre {
            get {
                return ResourceManager.GetString("Sobre", resourceCulture);
            }
        }
    }
}
