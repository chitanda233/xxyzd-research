package com.kwad.components.core.webview.tachikoma.b;

import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public abstract class w implements com.kwad.sdk.core.webview.c.a {
    protected com.kwad.sdk.core.webview.c.c atZ;
    protected CopyOnWriteArrayList<com.kwad.sdk.core.b> aua = new CopyOnWriteArrayList<>();

    public void a(final com.kwad.sdk.core.b bVar) {
        if (this.atZ != null) {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.b.w.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (w.this.atZ != null) {
                        w.this.atZ.b(bVar);
                    }
                }
            });
        } else {
            this.aua.add(bVar);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.atZ = cVar;
        if (this.aua.size() > 0) {
            for (com.kwad.sdk.core.b bVar : this.aua) {
                a(bVar);
                this.aua.remove(bVar);
            }
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public void onDestroy() {
        this.atZ = null;
    }
}
