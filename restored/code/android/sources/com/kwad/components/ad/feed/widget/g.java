package com.kwad.components.ad.feed.widget;

import android.content.Context;
import android.view.View;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.al;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends c {

    /* JADX INFO: renamed from: if, reason: not valid java name */
    private final com.kwad.components.core.video.a.InterfaceC0460a f4if;

    @Override // com.kwad.components.ad.feed.widget.c
    protected final int getDefaultClickArea() {
        return 3;
    }

    public g(Context context) {
        super(context);
        this.f4if = new com.kwad.components.core.video.a.InterfaceC0460a() { // from class: com.kwad.components.ad.feed.widget.g.1
            @Override // com.kwad.components.core.video.a.InterfaceC0460a
            public final void a(int i, al.a aVar) {
                int i2;
                int i3 = 3;
                boolean z = false;
                if (i == 1) {
                    i2 = 15;
                } else if (i == 2) {
                    i2 = 16;
                } else if (i != 3) {
                    i2 = 35;
                } else {
                    i2 = 39;
                    i3 = 1;
                    z = true;
                }
                g.this.cl();
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(g.this.getContext()).aF(g.this.mAdTemplate).b(g.this.mApkDownloadHelper).aD(i3).as(z).au(true).aB(5).aC(i2).d(aVar).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.g.1.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        g.this.zZ();
                    }
                }));
            }
        };
        setmIsShowComplianceView(false);
        setRadiusDp(4);
    }

    @Override // com.kwad.components.ad.feed.widget.c, com.kwad.components.core.widget.b
    public final void by() {
        super.by();
        View viewFindViewById = findViewById(R.id.ksad_feed_biserial_video);
        if (viewFindViewById != null) {
            viewFindViewById.setClipToOutline(true);
        }
    }

    @Override // com.kwad.components.core.widget.b
    public final int getLayoutId() {
        return R.layout.ksad_feed_biserial_video;
    }

    @Override // com.kwad.components.core.widget.b
    public final void setMargin(int i) {
        if (com.kwad.sdk.core.config.e.KO()) {
            return;
        }
        setBackgroundColor(-1);
    }

    @Override // com.kwad.components.ad.feed.widget.c
    protected final void ct() {
        this.hZ.setRatio(1.7857143f);
    }

    @Override // com.kwad.components.ad.feed.widget.c
    protected final com.kwad.components.core.video.a.InterfaceC0460a getVideoAdClickListener() {
        return this.f4if;
    }
}
