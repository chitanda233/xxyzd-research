package com.kwad.components.core.innerEc.a;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private final AtomicBoolean PV;
    private final String TAG;
    private final AtomicBoolean rJ;

    /* synthetic */ f(byte b) {
        this();
    }

    private f() {
        this.TAG = "AuthHintManager";
        this.rJ = new AtomicBoolean();
        this.PV = new AtomicBoolean();
    }

    static class a {
        private static final f Tk = new f(0);
    }

    public static f ru() {
        return a.Tk;
    }

    public final void ff() {
        h.rw().rx();
        this.rJ.set(true);
    }

    public final void eQ() {
        h.rw().ry();
        this.rJ.set(false);
    }

    public final synchronized void a(final AdTemplate adTemplate, final j jVar) {
        if (!this.PV.get() && !this.rJ.get()) {
            com.kwad.sdk.core.d.c.d("AuthHintManager", "startLoadAuthHintCard");
            this.PV.set(true);
            by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.a.f.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.a(adTemplate, new d() { // from class: com.kwad.components.core.innerEc.a.f.1.1
                        @Override // com.kwad.components.core.innerEc.a.d
                        public final void pr() {
                            com.kwad.sdk.core.d.c.d("AuthHintManager", "onViewShow");
                            f.this.ff();
                        }

                        @Override // com.kwad.components.core.innerEc.a.d
                        public final void gi() {
                            com.kwad.sdk.core.d.c.d("AuthHintManager", "onViewClose");
                            f.this.eQ();
                        }

                        @Override // com.kwad.components.core.innerEc.a.d
                        public final void rs() {
                            if (jVar != null) {
                                jVar.rm();
                            }
                            f.this.rJ.set(false);
                        }

                        @Override // com.kwad.components.core.innerEc.a.d
                        public final void rn() {
                            if (jVar != null) {
                                jVar.rn();
                            }
                        }

                        @Override // com.kwad.components.core.innerEc.a.d
                        public final void oV() {
                            if (jVar != null) {
                                jVar.oV();
                            }
                        }
                    });
                    f.this.PV.set(false);
                }
            });
            return;
        }
        com.kwad.sdk.core.d.c.d("AuthHintManager", "mLoadDisable: " + this.rJ.get() + ", mLoadDisable: " + this.PV.get());
    }
}
