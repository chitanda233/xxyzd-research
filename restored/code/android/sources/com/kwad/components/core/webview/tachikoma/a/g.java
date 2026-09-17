package com.kwad.components.core.webview.tachikoma.a;

import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.sdk.components.m;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class g implements m {
    protected abstract void a(y yVar);

    protected abstract void bR();

    protected abstract void bS();

    protected abstract void bT();

    protected abstract void bU();

    @Override // com.kwad.sdk.components.m
    public final Object call(Object... objArr) {
        if (objArr != null && objArr.length != 0) {
            try {
                final y yVar = new y();
                if (objArr[0] instanceof String) {
                    yVar.parseJson(new JSONObject((String) objArr[0]));
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.a.g.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            if (yVar.zD()) {
                                g.this.bU();
                                return;
                            }
                            if (yVar.zF()) {
                                return;
                            }
                            if (yVar.zG()) {
                                g.this.bS();
                                return;
                            }
                            if (yVar.zH()) {
                                g.this.bR();
                            } else if (yVar.zE()) {
                                g.this.bT();
                            } else if (yVar.isFailed()) {
                                g.this.a(yVar);
                            }
                        }
                    });
                }
            } catch (Throwable unused) {
            }
        }
        return null;
    }
}
