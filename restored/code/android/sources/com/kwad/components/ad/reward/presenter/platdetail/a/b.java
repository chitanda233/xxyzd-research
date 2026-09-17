package com.kwad.components.ad.reward.presenter.platdetail.a;

import android.view.View;
import android.widget.TextView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.b.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            b.this.k(j2);
        }
    };
    private TextView ks;
    private long ku;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        TextView textView = (TextView) findViewById(R.id.ksad_detail_call_btn);
        this.ks = textView;
        textView.setContentDescription("topBarCallLabel");
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.mApkDownloadHelper = this.ub.mApkDownloadHelper;
        this.ku = com.kwad.sdk.core.response.helper.d.ey(this.mAdTemplate);
        this.ub.sr.a(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        this.ks.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void k(long j) {
        if (j >= this.ku) {
            dr();
        }
    }

    private void dr() {
        if (this.ks.getVisibility() == 0) {
            return;
        }
        this.ks.setText(com.kwad.sdk.core.response.helper.d.ez(this.mAdTemplate));
        this.ks.setVisibility(0);
        this.ks.setOnClickListener(this);
        this.ks.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.b.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                b.this.ds();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ds() {
        this.ub.C("native_id");
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.ks) {
            this.ub.a(1, view.getContext(), 40, 1, this.ub.sr.getPlayDuration());
        }
    }
}
