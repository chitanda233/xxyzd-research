package com.kwad.components.core.innerEc.live.b.c;

import com.kwad.sdk.R;
import com.kwad.sdk.widget.swipe.HorizontalSwipeLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.core.innerEc.live.b.a.a {
    private HorizontalSwipeLayout Wn;
    private final HorizontalSwipeLayout.a Wo = new HorizontalSwipeLayout.a() { // from class: com.kwad.components.core.innerEc.live.b.c.f.1
        @Override // com.kwad.sdk.widget.swipe.HorizontalSwipeLayout.a
        public final void st() {
            if (f.this.Uj.Va != null) {
                f.this.Uj.Va.rK();
            }
        }

        @Override // com.kwad.sdk.widget.swipe.HorizontalSwipeLayout.a
        public final void su() {
            if (f.this.Uj.Va != null) {
                f.this.Uj.Va.rL();
            }
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.Wn = (HorizontalSwipeLayout) findViewById(R.id.ksad_live_horizontal_swipe_layout);
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Wn.a(this.Wo);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.Wn.b(this.Wo);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
    }
}
