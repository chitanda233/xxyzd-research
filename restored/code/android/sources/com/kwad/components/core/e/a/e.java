package com.kwad.components.core.e.a;

import android.app.Activity;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;
import java.util.Set;
import java.util.Stack;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private final List<b> PT;
    private final Stack<AdTemplate> PU;
    private final AtomicBoolean PV;
    private final Set<String> PW;
    private final String TAG;
    private final AtomicBoolean rJ;

    /* synthetic */ e(byte b) {
        this();
    }

    private e() {
        this.TAG = "InstalledActivateManager";
        this.PT = new CopyOnWriteArrayList();
        this.PU = new Stack<>();
        this.rJ = new AtomicBoolean();
        this.PV = new AtomicBoolean();
        this.PW = new HashSet();
    }

    static class a {
        private static final e Qa = new e(0);
    }

    public static e pt() {
        return a.Qa;
    }

    public final boolean isShowing() {
        return this.rJ.get();
    }

    public final void a(b bVar) {
        this.PT.add(bVar);
    }

    public final void b(b bVar) {
        this.PT.remove(bVar);
    }

    public final void ff() {
        this.rJ.set(true);
        Iterator<b> it = this.PT.iterator();
        while (it.hasNext()) {
            it.next().pr();
        }
    }

    public final void eQ() {
        this.rJ.set(false);
        Iterator<b> it = this.PT.iterator();
        while (it.hasNext()) {
            it.next().gi();
        }
    }

    public final synchronized void aA(AdTemplate adTemplate) {
        String strAE = com.kwad.sdk.core.response.helper.a.aE(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        if (com.kwad.sdk.core.response.helper.b.dY(adTemplate) && !this.PW.contains(strAE)) {
            this.PW.add(strAE);
            aB(adTemplate);
        }
    }

    private void aB(final AdTemplate adTemplate) {
        if (this.PV.get() || this.rJ.get()) {
            com.kwad.sdk.core.d.c.d("InstalledActivateManager", "mLoadDisable: " + this.rJ.get() + ", mLoadDisable: " + this.PV.get());
            this.PU.add(adTemplate);
        } else {
            com.kwad.sdk.core.d.c.d("InstalledActivateManager", "showInstalledActivate");
            this.PV.set(true);
            by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.core.e.a.e.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    final com.kwad.components.ad.b.a.a aVar = (com.kwad.components.ad.b.a.a) com.kwad.sdk.components.d.f(com.kwad.components.ad.b.a.a.class);
                    if (aVar != null && aVar.X()) {
                        aVar.a(new com.kwad.components.ad.b.a.c() { // from class: com.kwad.components.core.e.a.e.1.1
                            @Override // com.kwad.components.ad.b.a.c, com.kwad.components.ad.b.a.b
                            public final void Z() {
                                aVar.b(this);
                                pv();
                                com.kwad.sdk.core.d.c.d("InstalledActivateManager", "startShow onPushAdClose");
                            }
                        });
                    } else {
                        pv();
                    }
                }

                /* JADX INFO: Access modifiers changed from: private */
                public void pv() {
                    com.kwad.sdk.core.c.b.Mh();
                    if (!com.kwad.sdk.core.c.b.isEnable()) {
                        e.this.PV.set(false);
                        return;
                    }
                    com.kwad.sdk.core.c.b.Mh();
                    if (com.kwad.sdk.core.c.b.getCurrentActivity() != null) {
                        com.kwad.sdk.core.c.b.Mh();
                        if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
                            pw();
                            return;
                        }
                    }
                    com.kwad.sdk.core.c.b.Mh();
                    com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.core.e.a.e.1.2
                        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
                        /* JADX INFO: renamed from: onActivityResumed */
                        public final void d(Activity activity) {
                            super.d(activity);
                            com.kwad.sdk.core.c.b.Mh();
                            com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
                            com.kwad.sdk.core.d.c.d("InstalledActivateManager", "startShow onBackToForeground");
                            pw();
                        }
                    });
                }

                /* JADX INFO: Access modifiers changed from: private */
                public void pw() {
                    com.kwad.sdk.core.d.c.d("InstalledActivateManager", "startShow");
                    e.this.aC(adTemplate);
                    e.this.PV.set(false);
                    e.this.PW.remove(com.kwad.sdk.core.response.helper.a.aE(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
                }
            }, com.kwad.sdk.core.response.helper.b.dZ(adTemplate));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aC(AdTemplate adTemplate) {
        if (a(adTemplate, new b() { // from class: com.kwad.components.core.e.a.e.2
            @Override // com.kwad.components.core.e.a.b
            public final void pr() {
                com.kwad.sdk.core.d.c.d("InstalledActivateManager", "onViewShow");
                e.this.ff();
            }

            @Override // com.kwad.components.core.e.a.b
            public final void gi() {
                com.kwad.sdk.core.d.c.d("InstalledActivateManager", "onViewClose");
                e.this.eQ();
                e.this.pu();
            }
        })) {
            return;
        }
        pu();
    }

    private static boolean a(AdTemplate adTemplate, b bVar) {
        com.kwad.sdk.core.d.c.d("InstalledActivateManager", "showToActivityWindow");
        return new h().b(adTemplate, bVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void pu() {
        if (this.PU.isEmpty()) {
            return;
        }
        aB(this.PU.pop());
    }
}
