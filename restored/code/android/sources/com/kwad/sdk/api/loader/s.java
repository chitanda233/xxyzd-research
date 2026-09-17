package com.kwad.sdk.api.loader;

import android.text.TextUtils;
import android.util.Log;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
final class s {

    public interface c<T> {
        void m(T t);
    }

    public interface f<T> {
        void a(ab abVar, c<T> cVar);
    }

    static f<Boolean> HW() {
        return new e(new g(new d(new h(new b()))));
    }

    static abstract class a<T> implements c<T> {
        c<T> aIF;

        a(c<T> cVar) {
            this.aIF = cVar;
        }
    }

    static class e implements f<Boolean> {
        f<com.kwad.sdk.api.loader.a.C0495a> aIJ;

        e(f<com.kwad.sdk.api.loader.a.C0495a> fVar) {
            this.aIJ = fVar;
        }

        @Override // com.kwad.sdk.api.loader.s.f
        public final void a(final ab abVar, final c<Boolean> cVar) {
            this.aIJ.a(abVar, new c<com.kwad.sdk.api.loader.a.C0495a>() { // from class: com.kwad.sdk.api.loader.s.e.1
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.api.loader.s.c
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void m(com.kwad.sdk.api.loader.a.C0495a c0495a) {
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    try {
                        l.b(c0495a);
                        if (!com.kwad.sdk.api.loader.d.a(abVar.getContext(), getClass().getClassLoader(), c0495a.aHG.getPath(), c0495a.sdkVersion)) {
                            a(c0495a, 1, new RuntimeException("Apk pre install fail"));
                            return;
                        }
                        i.t(abVar.getContext(), c0495a.sdkVersion);
                        j.j(c0495a.aHG);
                        l.b(c0495a, System.currentTimeMillis() - jCurrentTimeMillis);
                        cVar.m(Boolean.TRUE);
                    } catch (Throwable th) {
                        a(c0495a, 2, th);
                    }
                }

                private void a(com.kwad.sdk.api.loader.a.C0495a c0495a, int i, Throwable th) {
                    j.j(c0495a.aHG);
                    l.b(c0495a, i, Log.getStackTraceString(th));
                }
            });
        }
    }

    static class g implements f<com.kwad.sdk.api.loader.a.C0495a> {
        f<com.kwad.sdk.api.loader.a.C0495a> aIJ;

        g(f<com.kwad.sdk.api.loader.a.C0495a> fVar) {
            this.aIJ = fVar;
        }

        @Override // com.kwad.sdk.api.loader.s.f
        public final void a(ab abVar, final c<com.kwad.sdk.api.loader.a.C0495a> cVar) {
            this.aIJ.a(abVar, new a<com.kwad.sdk.api.loader.a.C0495a>(cVar) { // from class: com.kwad.sdk.api.loader.s.g.1
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.api.loader.s.c
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void m(com.kwad.sdk.api.loader.a.C0495a c0495a) {
                    try {
                        File file = c0495a.aHG;
                        if (!x.k(file)) {
                            a(c0495a, 1, new RuntimeException("Security checkFileValid fail"));
                        } else if (!x.a(file, c0495a.md5)) {
                            a(c0495a, 2, new RuntimeException("Security checkMd5 fail"));
                        } else {
                            cVar.m(c0495a);
                        }
                    } catch (Throwable th) {
                        a(c0495a, 3, th);
                    }
                }

                private void a(com.kwad.sdk.api.loader.a.C0495a c0495a, int i, Throwable th) {
                    j.j(c0495a.aHG);
                    l.a(c0495a, i, th.getMessage());
                }
            });
        }
    }

    static class d implements f<com.kwad.sdk.api.loader.a.C0495a> {
        f<com.kwad.sdk.api.loader.a.C0495a> aIJ;

        d(f<com.kwad.sdk.api.loader.a.C0495a> fVar) {
            this.aIJ = fVar;
        }

        @Override // com.kwad.sdk.api.loader.s.f
        public final void a(final ab abVar, final c<com.kwad.sdk.api.loader.a.C0495a> cVar) {
            this.aIJ.a(abVar, new a<com.kwad.sdk.api.loader.a.C0495a>(cVar) { // from class: com.kwad.sdk.api.loader.s.d.1
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.api.loader.s.c
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void m(com.kwad.sdk.api.loader.a.C0495a c0495a) {
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    File fileV = null;
                    try {
                        l.a(c0495a);
                        fileV = j.v(abVar.getContext(), c0495a.sdkVersion);
                        k.c(c0495a.aHF, fileV);
                        l.a(c0495a, System.currentTimeMillis() - jCurrentTimeMillis);
                        c0495a.aHG = fileV;
                        cVar.m(c0495a);
                    } catch (Throwable th) {
                        l.a(c0495a, System.currentTimeMillis() - jCurrentTimeMillis, Log.getStackTraceString(th));
                        j.j(fileV);
                    }
                }
            });
        }
    }

    static class h implements f<com.kwad.sdk.api.loader.a.C0495a> {
        f<com.kwad.sdk.api.loader.a.C0495a> aIJ;

        h(f<com.kwad.sdk.api.loader.a.C0495a> fVar) {
            this.aIJ = fVar;
        }

        @Override // com.kwad.sdk.api.loader.s.f
        public final void a(final ab abVar, final c<com.kwad.sdk.api.loader.a.C0495a> cVar) {
            this.aIJ.a(abVar, new c<com.kwad.sdk.api.loader.a.C0495a>() { // from class: com.kwad.sdk.api.loader.s.h.1
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.api.loader.s.c
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void m(com.kwad.sdk.api.loader.a.C0495a c0495a) {
                    String strBn = i.bn(abVar.getContext());
                    if (TextUtils.isEmpty(strBn)) {
                        strBn = com.kwad.sdk.api.c.HG().getSDKVersion();
                    }
                    String str = c0495a.sdkVersion;
                    com.kwad.sdk.api.loader.b.a(abVar.getContext(), "interval", c0495a.interval);
                    com.kwad.sdk.api.loader.b.a(abVar.getContext(), "lastUpdateTime", System.currentTimeMillis());
                    if (c0495a.HN()) {
                        aa.bu(abVar.getContext());
                        new RuntimeException("DynamicType == -1, curVersion: " + strBn);
                    } else if (i.M(c0495a.sdkVersion, strBn) && c0495a.HM()) {
                        cVar.m(c0495a);
                    } else {
                        new RuntimeException("No new sdkVersion. remote sdkVersion:" + c0495a.sdkVersion + " currentDynamicVersion:" + strBn + " dynamicType:" + c0495a.aHE);
                    }
                }
            });
        }
    }

    static class b implements f<com.kwad.sdk.api.loader.a.C0495a> {
        b() {
        }

        @Override // com.kwad.sdk.api.loader.s.f
        public final void a(final ab abVar, final c<com.kwad.sdk.api.loader.a.C0495a> cVar) {
            try {
                new com.kwad.sdk.api.loader.h(abVar).a(new com.kwad.sdk.api.loader.h.a() { // from class: com.kwad.sdk.api.loader.s.b.1
                    @Override // com.kwad.sdk.api.loader.h.a
                    public final void a(com.kwad.sdk.api.loader.a.b bVar) {
                        new StringBuilder("ConfigProducer onSuccess data:").append(bVar);
                        if (bVar.isLegal()) {
                            cVar.m(bVar.aHH);
                        } else {
                            new RuntimeException("UpdateData is illegal");
                        }
                        try {
                            com.kwad.sdk.api.loader.f.bm(abVar.getContext()).cancel();
                        } catch (Throwable unused) {
                        }
                    }
                });
            } catch (Exception unused) {
            }
        }
    }
}
