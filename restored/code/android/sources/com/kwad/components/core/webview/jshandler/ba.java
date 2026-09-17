package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class ba implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;
    private final Handler aqf = new Handler(Looper.getMainLooper());
    private final c arz;

    public static final class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public int likeUserCount;
        public long liveDuration;
        public int status;
        public long totalWatchingDuration;
        public int watchingUserCount;
        public String displayWatchingUserCount = "0";
        public String displayLikeUserCount = "0";
    }

    public interface c {
        void a(b bVar);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerLiveListener";
    }

    public ba(c cVar) {
        this.arz = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
        this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.ba.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ba.this.arz.a(new b(ba.this.apz));
            }
        });
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
        this.aqf.removeCallbacksAndMessages(null);
    }

    public static final class b {
        WeakReference<com.kwad.sdk.core.webview.c.c> arB;

        public b(com.kwad.sdk.core.webview.c.c cVar) {
            this.arB = new WeakReference<>(cVar);
        }

        public final void a(a aVar) {
            com.kwad.sdk.core.webview.c.c cVar = this.arB.get();
            if (cVar != null) {
                cVar.b(aVar);
            }
        }
    }
}
