package com.kwad.sdk.core.video.videoview;

import android.content.Context;
import android.widget.RelativeLayout;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b extends RelativeLayout {
    protected final c aZI;
    private Runnable amD;

    protected abstract void onPlayStateChanged(int i);

    public void q(int i, int i2) {
    }

    protected abstract void reset();

    protected abstract void xw();

    public b(Context context, c cVar) {
        super(context);
        this.aZI = cVar;
    }

    protected final void xC() {
        xD();
        if (this.amD == null) {
            this.amD = new Runnable() { // from class: com.kwad.sdk.core.video.videoview.b.1
                @Override // java.lang.Runnable
                public final void run() {
                    b.this.xw();
                    if (b.this.amD != null) {
                        b bVar = b.this;
                        bVar.postDelayed(bVar.amD, 1000L);
                    }
                }
            };
        }
        post(this.amD);
    }

    protected final void xD() {
        Runnable runnable = this.amD;
        if (runnable != null) {
            removeCallbacks(runnable);
            this.amD = null;
        }
    }
}
