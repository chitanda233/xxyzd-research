package com.kwad.components.ad.reward.widget.tailframe;

import android.content.Context;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.reward.g;
import com.kwad.components.core.page.widget.TextProgressBar;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.d;
import com.kwad.sdk.widget.h;
import com.kwad.sdk.wrapper.m;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a implements d {
    protected View FO;
    protected ImageView FP;
    private com.kwad.components.ad.widget.tailframe.appbar.a FQ;
    private TailFrameBarH5View FR;
    private b FS;
    private TextProgressBar FT;
    private View FU;
    private int FV;
    private TextView gP;
    protected AdInfo mAdInfo;
    protected AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    protected KsLogoView mLogoView;
    private JSONObject mReportExtData;
    private g ub;

    public a(int i) {
        this.FV = i;
    }

    public final void setCallerContext(g gVar) {
        this.ub = gVar;
    }

    public void B(Context context) {
        View viewA = m.a(context, this.FV, null, false);
        this.FO = viewA;
        this.FP = (ImageView) viewA.findViewById(R.id.ksad_video_thumb_img);
        this.mLogoView = (KsLogoView) this.FO.findViewById(R.id.ksad_video_tf_logo);
        this.FQ = (com.kwad.components.ad.widget.tailframe.appbar.a) this.FO.findViewById(R.id.ksad_video_app_tail_frame);
        this.FR = (TailFrameBarH5View) this.FO.findViewById(R.id.ksad_video_h5_tail_frame);
    }

    public final void g(boolean z, boolean z2) {
        this.FR.h(z, z2);
    }

    public void a(AdTemplate adTemplate, JSONObject jSONObject, b bVar) {
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        this.mReportExtData = jSONObject;
        this.FS = bVar;
        this.mLogoView.bh(this.mAdTemplate);
        lN();
        this.FO.setClickable(true);
        new h(this.FO, this);
    }

    private void bindDownloadListener() {
        this.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate, this.mReportExtData, new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.reward.widget.tailframe.a.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.aK(a.this.mAdInfo), 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.ev(i), i);
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.ew(i), i);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.cF(a.this.mAdTemplate), 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.aK(a.this.mAdInfo), 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                a.this.FQ.E(a.this.mAdInfo);
                a.this.FT.e(com.kwad.sdk.core.response.helper.a.af(a.this.mAdInfo), 0);
            }
        });
    }

    private void lL() {
        this.FO.setOnClickListener(null);
        this.mApkDownloadHelper = null;
    }

    public final View lM() {
        return this.FO;
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        d(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mAdTemplate, f, f2, f3, f4)) {
            d(view, false);
        }
    }

    public final void destroy() {
        com.kwad.components.ad.widget.tailframe.appbar.a aVar = this.FQ;
        if (aVar != null) {
            aVar.lP();
            this.FQ.setVisibility(8);
        }
        TailFrameBarH5View tailFrameBarH5View = this.FR;
        if (tailFrameBarH5View != null) {
            tailFrameBarH5View.lP();
            this.FR.setVisibility(8);
        }
        lL();
    }

    public final void lu() {
        com.kwad.components.ad.widget.tailframe.appbar.a aVar = this.FQ;
        if (aVar != null) {
            aVar.lP();
        }
        TailFrameBarH5View tailFrameBarH5View = this.FR;
        if (tailFrameBarH5View != null) {
            tailFrameBarH5View.lP();
        }
    }

    private void lN() {
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo) || e.O(this.mAdTemplate)) {
            this.FQ.j(this.mAdTemplate);
            this.FQ.setVisibility(0);
            this.FT = this.FQ.getTextProgressBar();
            if (!e.O(this.mAdTemplate)) {
                this.FT.setClickable(true);
                new h(this.FT, this);
                bindDownloadListener();
                return;
            } else {
                View btnInstallContainer = this.FQ.getBtnInstallContainer();
                this.FU = btnInstallContainer;
                btnInstallContainer.setClickable(true);
                new h(this.FU, this);
                return;
            }
        }
        this.FR.j(this.mAdTemplate);
        TextView h5OpenBtn = this.FR.getH5OpenBtn();
        this.gP = h5OpenBtn;
        h5OpenBtn.setClickable(true);
        this.FR.setVisibility(0);
        new h(this.gP, this);
    }

    /* JADX WARN: Code restructure failed: missing block: B:16:0x002d, code lost:
    
        r1 = 1;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    private void d(android.view.View r6, final boolean r7) {
        /*
            r5 = this;
            com.kwad.sdk.core.response.model.AdTemplate r0 = r5.mAdTemplate
            boolean r0 = com.kwad.sdk.core.response.helper.e.O(r0)
            r1 = 2
            r2 = 1
            if (r0 == 0) goto L21
            if (r7 == 0) goto Le
            r7 = r2
            goto L10
        Le:
            r7 = 153(0x99, float:2.14E-43)
        L10:
            com.kwad.components.ad.reward.g r0 = r5.ub
            android.view.View r3 = r5.FO
            android.content.Context r3 = r3.getContext()
            android.view.View r4 = r5.FU
            if (r6 != r4) goto L1d
            r1 = r2
        L1d:
            r0.a(r2, r3, r7, r1)
            return
        L21:
            com.kwad.sdk.core.response.model.AdInfo r0 = r5.mAdInfo
            boolean r0 = com.kwad.sdk.core.response.helper.a.aL(r0)
            if (r0 == 0) goto L2f
            com.kwad.components.core.page.widget.TextProgressBar r0 = r5.FT
            if (r6 != r0) goto L34
        L2d:
            r1 = r2
            goto L34
        L2f:
            android.widget.TextView r0 = r5.gP
            if (r6 != r0) goto L34
            goto L2d
        L34:
            com.kwad.components.core.e.d.a$a r0 = new com.kwad.components.core.e.d.a$a
            android.content.Context r3 = r6.getContext()
            r0.<init>(r3)
            com.kwad.sdk.core.response.model.AdTemplate r3 = r5.mAdTemplate
            com.kwad.components.core.e.d.a$a r0 = r0.aF(r3)
            com.kwad.components.core.e.d.d r3 = r5.mApkDownloadHelper
            com.kwad.components.core.e.d.a$a r0 = r0.b(r3)
            r3 = 0
            if (r1 != r2) goto L4e
            r4 = r2
            goto L4f
        L4e:
            r4 = r3
        L4f:
            com.kwad.components.core.e.d.a$a r0 = r0.aC(r4)
            com.kwad.components.core.e.d.a$a r0 = r0.aB(r2)
            com.kwad.components.core.page.widget.TextProgressBar r4 = r5.FT
            if (r6 != r4) goto L5c
            goto L5d
        L5c:
            r2 = r3
        L5d:
            com.kwad.components.core.e.d.a$a r6 = r0.as(r2)
            com.kwad.components.core.e.d.a$a r6 = r6.aD(r1)
            com.kwad.components.ad.reward.widget.tailframe.a$2 r0 = new com.kwad.components.ad.reward.widget.tailframe.a$2
            r0.<init>()
            com.kwad.components.core.e.d.a$a r6 = r6.a(r0)
            com.kwad.components.core.e.d.a.a(r6)
            return
        */
        throw new UnsupportedOperationException("Method not decompiled: com.kwad.components.ad.reward.widget.tailframe.a.d(android.view.View, boolean):void");
    }
}
