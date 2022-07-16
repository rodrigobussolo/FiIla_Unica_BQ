# FiIla_Unica_BQ

FilaUnica_BQ - Desenvolvido para estudo
A função deste aplicativo é buscar dentro das tags HTML de um site específico (https://filaunica.brusque.sc.gov.br/dmd/pub/filapub.php?f=B1#), a lista de condidados a vagas nas cresches do município onde moro.

Cada candidato pode se candidatar a vagas em 3 creches
Existe um posicionamento geral exibido no site, porém, não é possível enxergar tal informação por creche onde o aluno é candidato a vaga. O aplicativo que estou criando deve exibir tal informação, a partir do número ro protocolo do aluno e analisando os dados gerais do site.
Problemas:

Na empresa onde trabalho, consegui rodar o aplicativo com sucesso tanto no emulador como no meu celular, porém, quando estou em outra rede wifi ou utilizando os Dados Móveis do celular, o app falha.

O erro apresentado é este:

System.NullReferenceException: 'Object reference not set to an instance of an object.'

  $exception	{System.NullReferenceException: Object reference not set to an instance of an object.
at Android.Runtime.JNINativeWrapper._unhandled_exception (System.Exception e) [0x0000e] in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:12 at Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PPL_V (_JniMarshal_PPL_V callback, System.IntPtr jnienv, System.IntPtr klazz, System.IntPtr p0) [0x0001d] in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:111 at (wrapper native-to-managed) Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PPL_V(intptr,intptr,intptr)} System.NullReferenceException
Próximos passos:

Gravar as informações em um banco de dados (SQLLite, por exemplo)
Possilitar a busca por nível:
Berçário 1
Berçário 2
Infantil 1
Infantil 2
Pré escola 1
