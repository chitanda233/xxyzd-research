package com.kwad.components.core.proxy.a;

import android.os.SystemClock;
import com.kwad.components.core.proxy.PageCreateStage;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private String ajr;
    private long ajs;
    private long ajt;
    private long aju;
    private boolean ajv;
    private c ajw;

    public a(c cVar) {
        this.ajw = cVar;
    }

    public final void be(String str) {
        this.ajr = str;
    }

    public final void O(long j) {
        this.ajs = j;
        this.ajt = SystemClock.uptimeMillis();
    }

    public final void vW() {
        if (this.ajv) {
            return;
        }
        this.ajv = true;
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.proxy.a.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.aju = SystemClock.uptimeMillis();
                a.this.report();
            }
        });
    }

    public final void a(PageCreateStage pageCreateStage) {
        c cVar = this.ajw;
        if (cVar != null) {
            cVar.onCreateStageChange(pageCreateStage);
        }
    }

    public final void report() {
        b bVar = new b();
        bVar.ajr = this.ajr;
        long j = this.ajs;
        bVar.ajz = j != 0 ? this.ajt - j : 0L;
        long j2 = this.ajt;
        bVar.ajA = j2 != 0 ? this.aju - j2 : 0L;
        long j3 = this.ajs;
        bVar.ajy = j3 != 0 ? this.aju - j3 : 0L;
        com.kwad.components.core.p.a.vX().a(bVar);
        com.kwad.sdk.core.d.c.d("PageMonitor", bVar.toString());
    }
}
