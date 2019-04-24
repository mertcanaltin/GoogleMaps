#                                                                                                                                                                                         ##

## ** C Sharp Uygulama İçerisinden Uyumluluk Modu Ayarlama **                                                                                                                                                                                     

Öncelikle söylemeliyim ki bu konu eğitim sıralaması göre erken bir konu oldu. Şimdi yazmamın sebebi bu sorunu yaşıyor yazılımcı dostlarım için çözüm yolu olması. Bu sebeple yöntemde kod yazmacağız.

Şimdi Regedit 'i açalım ve sonraki yola erişelim.

HKEY_CURRENT_USER / Yazılım / Microsoft / Windows NT / CurrentVersion / AppCompatFlags / Katmanlar

Bu yola eriştikten sonra boş alanda sağ tıklayıp “Yeni” diyelim ve değerin adı olarak projenizin tam yolunu yazın. Örneğin;

C: Program Files / Programim / Program.exe

Bu eklemeyi yaparkentan sonra, bu yeni değere çift tıklayın ve “Değer Verisi” yazan yere hangi uyumluluk konusunda çalışıyorken onu yazıyoyuz.

Örneğin;

WINXPSP3 RUNASADMIN

Burada, Windows XP SP3'te projemiz Windows XP SP3'te uyumluluk taraması ve zamanını “Yönetici olarak çalıştır”

Eveeeeet. Yöntemimiz bu şekilde dostlar. İmalatı işlemi manuel olarak dalıdır. Elbette ki C keskin kodları ile de yapıyor. Ayrıca exe dosyası üzerinde sağ tarafta.
