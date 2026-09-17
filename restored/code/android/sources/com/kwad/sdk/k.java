package com.kwad.sdk;

import android.content.Context;
import com.kwad.sdk.core.imageloader.ImageLoaderProxy;
import com.kwad.sdk.core.report.s;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import java.io.File;
import java.io.InputStream;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class k {
    public static void FA() {
        byte b2 = 0;
        ServiceProvider.put(com.kwad.sdk.service.a.f.class, new b(b2));
        ServiceProvider.put(com.kwad.sdk.service.a.h.class, new c(b2));
        ServiceProvider.put(com.kwad.sdk.service.a.e.class, new com.kwad.sdk.service.a.e() { // from class: com.kwad.sdk.k.1
            @Override // com.kwad.sdk.service.a.e
            public final void gatherException(Throwable th) {
                com.kwad.components.core.d.a.reportSdkCaughtException(th);
            }

            @Override // com.kwad.sdk.service.a.e
            public final void I(String str, String str2) {
                com.kwad.components.core.d.a.j(str, str2);
            }

            @Override // com.kwad.sdk.service.a.e
            public final void a(final com.kwad.sdk.service.a.c cVar) {
                com.kwad.components.core.d.a.a(new com.kwad.components.core.d.a.b() { // from class: com.kwad.sdk.k.1.1
                    @Override // com.kwad.components.core.d.a.b
                    public final String getKey() {
                        com.kwad.sdk.service.a.c cVar2 = cVar;
                        if (cVar2 != null) {
                            return cVar2.getKey();
                        }
                        return null;
                    }

                    @Override // com.kwad.components.core.d.a.b
                    public final JSONObject getValue() {
                        com.kwad.sdk.service.a.c cVar2 = cVar;
                        if (cVar2 != null) {
                            return cVar2.getValue();
                        }
                        return null;
                    }
                });
            }

            @Override // com.kwad.sdk.service.a.e
            public final void a(final com.kwad.sdk.service.a.g gVar) {
                com.kwad.components.core.d.a.a(new com.kwad.components.core.d.a.c() { // from class: com.kwad.sdk.k.1.2
                    @Override // com.kwad.components.core.d.a.c
                    public final void onCrashOccur(int i, String str) {
                        com.kwad.sdk.service.a.g gVar2 = gVar;
                        if (gVar2 != null) {
                            gVar2.o(i, str);
                        }
                    }
                });
            }
        });
        ServiceProvider.put(com.kwad.sdk.service.a.d.class, new com.kwad.sdk.service.a.d() { // from class: com.kwad.sdk.k.2
            @Override // com.kwad.sdk.service.a.d
            public final File cM(String str) {
                return com.kwad.sdk.core.diskcache.b.a.LI().cM(str);
            }

            @Override // com.kwad.sdk.service.a.d
            public final void a(boolean z, String str, String str2, String str3) {
                com.kwad.sdk.core.diskcache.b.a.LI().eo(str);
            }
        });
        ServiceProvider.put(com.kwad.sdk.service.a.j.class, new com.kwad.sdk.service.a.j() { // from class: com.kwad.sdk.k.3
            @Override // com.kwad.sdk.service.a.j
            public final InputStream wrapInputStream(InputStream inputStream) {
                com.kwad.components.core.q.b.wr();
                return com.kwad.components.core.q.b.wrapInputStream(inputStream);
            }

            @Override // com.kwad.sdk.service.a.j
            public final boolean ws() {
                com.kwad.components.core.q.b.wr();
                return com.kwad.components.core.q.b.ws();
            }

            @Override // com.kwad.sdk.service.a.j
            public final int wt() {
                com.kwad.components.core.q.b.wr();
                return com.kwad.components.core.q.b.wt();
            }

            @Override // com.kwad.sdk.service.a.j
            public final int wu() {
                return com.kwad.components.core.q.b.wr().wu();
            }
        });
        ServiceProvider.put(com.kwad.sdk.core.network.k.class, new com.kwad.sdk.core.network.k() { // from class: com.kwad.sdk.k.4
            @Override // com.kwad.sdk.core.network.k
            public final com.kwad.sdk.core.b FB() {
                return com.kwad.components.core.request.model.b.wq();
            }

            @Override // com.kwad.sdk.core.network.k
            public final void a(com.kwad.sdk.core.network.j jVar) {
                com.kwad.sdk.commercial.c.b(jVar);
            }

            @Override // com.kwad.sdk.core.network.k
            public final void a(com.kwad.sdk.core.network.i iVar) {
                com.kwad.sdk.commercial.c.b(iVar);
            }
        });
        ServiceProvider.put(com.kwad.sdk.service.a.i.class, ImageLoaderProxy.INSTANCE);
        int iA = com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPA);
        if (iA > 0) {
            ImageLoaderProxy.INSTANCE.setCacheSize(iA);
        }
        ServiceProvider.put(com.kwad.sdk.service.a.b.class, new com.kwad.sdk.service.a.b() { // from class: com.kwad.sdk.k.5
            @Override // com.kwad.sdk.service.a.b
            public final void J(String str, String str2) {
                com.kwad.sdk.core.d.c.e("image_load_failed_info", "errorMsg:" + str2 + "\nurl:" + str);
            }

            @Override // com.kwad.sdk.service.a.b
            public final void bi(AdTemplate adTemplate) {
                com.kwad.components.core.p.a.vX().i(adTemplate, 21007);
            }

            @Override // com.kwad.sdk.service.a.b
            public final void FC() {
                com.kwad.components.core.p.a.vX().aK(ServiceProvider.getContext());
            }

            @Override // com.kwad.sdk.service.a.b
            public final void e(JSONObject jSONObject, int i) {
                com.kwad.components.core.p.a.vX().e(jSONObject, i);
            }
        });
        ServiceProvider.put(s.class, new s() { // from class: com.kwad.sdk.k.6
            @Override // com.kwad.sdk.core.report.s
            public final boolean ak(long j) {
                com.kwad.sdk.core.config.item.q qVar = com.kwad.sdk.core.config.c.aNR;
                return com.kwad.sdk.core.config.item.q.ak(j);
            }

            @Override // com.kwad.sdk.core.report.s
            public final int FD() {
                return com.kwad.sdk.core.config.e.FD();
            }

            @Override // com.kwad.sdk.core.report.s
            public final int Ar() {
                com.kwad.components.a.a.a aVar = (com.kwad.components.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
                if (aVar != null) {
                    return aVar.Ar();
                }
                return 0;
            }
        });
        ServiceProvider.put(com.kwad.sdk.core.video.a.f.class, new com.kwad.sdk.core.video.a.f() { // from class: com.kwad.sdk.k.7
            @Override // com.kwad.sdk.core.video.a.f
            public final boolean FE() {
                return com.kwad.sdk.core.config.e.FE();
            }

            @Override // com.kwad.sdk.core.video.a.f
            public final boolean FF() {
                return com.kwad.sdk.core.config.e.FF();
            }

            @Override // com.kwad.sdk.core.video.a.f
            public final boolean As() {
                return ((com.kwad.components.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class)).As();
            }
        });
        ServiceProvider.put(com.kwad.sdk.utils.b.b.class, new com.kwad.sdk.utils.b.b() { // from class: com.kwad.sdk.k.8
            @Override // com.kwad.sdk.utils.b.b
            public final void a(com.kwad.sdk.utils.b.a aVar) {
                if (aVar == null) {
                    return;
                }
                com.kwad.sdk.commercial.c.b(aVar);
            }
        });
        ServiceProvider.put(com.kwad.sdk.service.a.a.class, new a(b2));
    }

    static class b implements com.kwad.sdk.service.a.f {
        private b() {
        }

        /* synthetic */ b(byte b) {
            this();
        }

        @Override // com.kwad.sdk.service.a.f
        public final Context getContext() {
            return ServiceProvider.getContext();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String getAppId() {
            return ServiceProvider.getAppId();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String getAppName() {
            return ServiceProvider.getAppName();
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean FG() {
            return o.GE().FG();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String getApiVersion() {
            return o.GE().getApiVersion();
        }

        @Override // com.kwad.sdk.service.a.f
        public final int getApiVersionCode() {
            return o.GE().getApiVersionCode();
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean FH() {
            return o.GE().FH();
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean FI() {
            return o.GE().FI();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String getSDKVersion() {
            o.GE();
            return o.getSDKVersion();
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean bj(AdTemplate adTemplate) {
            com.kwad.components.a.a.a aVar = (com.kwad.components.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
            return aVar != null && aVar.At();
        }

        @Override // com.kwad.sdk.service.a.f
        public final com.kwad.sdk.core.response.helper.g Au() {
            com.kwad.components.a.a.a aVar = (com.kwad.components.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
            if (aVar != null) {
                return aVar.Au();
            }
            return null;
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean tG() {
            com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
            if (aVar != null) {
                return aVar.tG();
            }
            return false;
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean tF() {
            com.kwad.components.core.offline.a.b.a aVar = (com.kwad.components.core.offline.a.b.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.b.a.class);
            if (aVar != null) {
                return aVar.tF();
            }
            return false;
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean tD() {
            com.kwad.components.core.offline.a.a.a aVar = (com.kwad.components.core.offline.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.a.a.class);
            if (aVar != null) {
                return aVar.tD();
            }
            return false;
        }

        @Override // com.kwad.sdk.service.a.f
        public final boolean FJ() {
            return o.GE().FJ();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String FK() {
            return com.kwad.sdk.kgeo.a.FK();
        }

        @Override // com.kwad.sdk.service.a.f
        public final com.kwad.sdk.core.b FL() {
            return com.kwad.sdk.kgeo.a.RK();
        }

        @Override // com.kwad.sdk.service.a.f
        public final List<AdTemplate> FM() {
            return com.kwad.sdk.core.download.b.LK().FM();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String FN() {
            return i.Fc();
        }

        @Override // com.kwad.sdk.service.a.f
        public final JSONObject FO() {
            return com.kwad.components.core.p.a.vX().n("", "").toJson();
        }

        @Override // com.kwad.sdk.service.a.f
        public final JSONObject FP() {
            return new com.kwad.sdk.core.report.f((List<com.kwad.sdk.core.report.n>) null).getBodyParams();
        }

        @Override // com.kwad.sdk.service.a.f
        public final Map<String, String> FQ() {
            return new com.kwad.sdk.core.report.f((List<com.kwad.sdk.core.report.n>) null).getHeader();
        }

        @Override // com.kwad.sdk.service.a.f
        public final String av(String str) {
            return com.kwad.sdk.core.a.d.av(str);
        }

        @Override // com.kwad.sdk.service.a.f
        public final void a(String str, Map<String, String> map, String str2) {
            com.kwad.sdk.core.a.d.a(str, map, str2);
        }
    }

    static class c implements com.kwad.sdk.service.a.h {
        private c() {
        }

        /* synthetic */ c(byte b) {
            this();
        }

        @Override // com.kwad.sdk.service.a.h
        public final <T> T getAppConfigData(T t, com.kwad.sdk.g.b<JSONObject, T> bVar) {
            return (T) com.kwad.sdk.core.config.e.Kd().getAppConfigData(null, bVar);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean al(long j) {
            return com.kwad.sdk.core.config.e.al(j);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FR() {
            return com.kwad.sdk.core.config.e.FR();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FS() {
            return com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aOe);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FT() {
            return com.kwad.sdk.core.config.e.FT();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FU() {
            return com.kwad.sdk.core.config.e.FU();
        }

        @Override // com.kwad.sdk.service.a.h
        public final String FV() {
            return com.kwad.sdk.core.config.e.FV();
        }

        @Override // com.kwad.sdk.service.a.h
        public final String FW() {
            return com.kwad.sdk.core.config.e.FW();
        }

        @Override // com.kwad.sdk.service.a.h
        public final List<String> FX() {
            return com.kwad.sdk.core.config.e.FX();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean cN(String str) {
            return com.kwad.sdk.core.config.a.cN(str);
        }

        @Override // com.kwad.sdk.service.a.h
        public final String getUserAgent() {
            return com.kwad.sdk.core.config.e.getUserAgent();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FY() {
            return com.kwad.sdk.core.config.e.FY();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean FZ() {
            return com.kwad.sdk.core.config.e.FZ();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Ga() {
            return com.kwad.sdk.core.config.e.Ga();
        }

        @Override // com.kwad.sdk.service.a.h
        public final String getAppId() {
            return ServiceProvider.getAppId();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gb() {
            return com.kwad.sdk.core.config.e.Ki();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int be(Context context) {
            return com.kwad.sdk.core.config.item.c.bN(context);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gc() {
            return com.kwad.sdk.core.config.e.Gc();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gd() {
            return com.kwad.sdk.core.config.e.Gd();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Ge() {
            return com.kwad.sdk.core.config.e.Ge();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Gf() {
            return com.kwad.sdk.core.config.e.Gf();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean DH() {
            return com.kwad.sdk.core.config.e.DH();
        }

        @Override // com.kwad.sdk.service.a.h
        public final double Gg() {
            return com.kwad.sdk.core.config.e.Gg();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gh() {
            return com.kwad.sdk.core.config.e.Gh();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gi() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPM);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gj() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPN);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gk() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPO);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gl() {
            return com.kwad.sdk.core.config.e.Gl();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Gm() {
            return com.kwad.sdk.core.config.e.Gm();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gn() {
            return com.kwad.sdk.core.config.e.Gn();
        }

        @Override // com.kwad.sdk.service.a.h
        public final String Go() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPW);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gp() {
            return com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQa);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gq() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aQu);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gr() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aOr);
        }

        @Override // com.kwad.sdk.service.a.h
        public final String Gs() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aOs);
        }

        @Override // com.kwad.sdk.service.a.h
        public final String Gt() {
            return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aQg);
        }

        @Override // com.kwad.sdk.service.a.h
        public final int cO(String str) {
            return com.kwad.sdk.core.config.e.cO(str);
        }

        @Override // com.kwad.sdk.service.a.h
        public final int cP(String str) {
            return com.kwad.sdk.core.config.e.cP(str);
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gu() {
            return com.kwad.sdk.core.config.c.aQm.getValue().booleanValue();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Gv() {
            return com.kwad.sdk.core.config.c.aQn.getValue().intValue();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean Gw() {
            return com.kwad.sdk.core.config.e.Gw();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Gx() {
            return com.kwad.sdk.core.config.e.Gx();
        }

        @Override // com.kwad.sdk.service.a.h
        public final int Gy() {
            return com.kwad.sdk.core.config.e.Gy();
        }

        @Override // com.kwad.sdk.service.a.h
        public final boolean enableInflaterOptimize() {
            return com.kwad.sdk.core.config.e.enableInflaterOptimize();
        }
    }

    static class a implements com.kwad.sdk.service.a.a {
        private a() {
        }

        /* synthetic */ a(byte b) {
            this();
        }

        @Override // com.kwad.sdk.service.a.a
        public final void k(Context context, AdTemplate adTemplate) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(context).aF(adTemplate).au(true));
        }
    }
}
