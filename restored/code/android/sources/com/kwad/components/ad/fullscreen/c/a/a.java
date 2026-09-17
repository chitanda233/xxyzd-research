package com.kwad.components.ad.fullscreen.c.a;

import android.os.Message;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.cc;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b implements cc.a {
    private cc ca;
    private m jX = new m() { // from class: com.kwad.components.ad.fullscreen.c.a.a.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayEnd() {
            super.onLivePlayEnd();
            if (a.this.kp) {
                return;
            }
            a.this.ca.sendEmptyMessageDelayed(1, 500L);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            if (!a.this.ub.sr.lq()) {
                a.this.a(j, j2);
                a.this.kq = j2;
            } else if (j2 > 800) {
                a.this.kq = j2;
                if (a.this.kq > j) {
                    a.this.kn.setVisibility(8);
                    ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) a.this.ko.getLayoutParams();
                    marginLayoutParams.leftMargin = com.kwad.sdk.c.a.a.a(a.this.getContext(), 0.0f);
                    a.this.ko.setLayoutParams(marginLayoutParams);
                }
                a.this.a(j, j2);
                a.a(a.this, true);
            }
        }
    };
    private TextView kn;
    private View ko;
    private boolean kp;
    private long kq;
    private AdInfo mAdInfo;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.kp = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kn = (TextView) findViewById(R.id.ksad_video_count_down);
        this.ko = findViewById(R.id.ksad_video_sound_switch);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ca = new cc(this);
        dq();
        if (this.ub.sr.lq()) {
            G(30);
        }
    }

    private void dq() {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        this.mAdInfo = adInfoEM;
        this.kn.setText(String.valueOf(com.kwad.sdk.core.response.helper.a.N(adInfoEM)));
        this.kn.setVisibility(0);
        this.ub.sr.a(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        this.kp = false;
        this.ca.removeCallbacksAndMessages(null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(long j, long j2) {
        int i = (int) (((j - j2) / 1000.0f) + 0.5f);
        if (i <= 0) {
            i = 1;
        }
        G(i);
    }

    private void G(int i) {
        this.kn.setText(String.valueOf(i));
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        if (message.what == 1) {
            if (this.ub.hf() || this.ub.he()) {
                this.ca.sendEmptyMessageDelayed(1, 500L);
                return;
            }
            long j = this.kq + 500;
            this.kq = j;
            if (j > 30000) {
                this.kn.setVisibility(8);
                ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) this.ko.getLayoutParams();
                marginLayoutParams.leftMargin = com.kwad.sdk.c.a.a.a(getContext(), 0.0f);
                this.ko.setLayoutParams(marginLayoutParams);
                return;
            }
            a(30000L, j);
            this.ca.sendEmptyMessageDelayed(1, 500L);
        }
    }
}
