package com.kwad.components.core.page.d.a;

import android.app.Activity;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.b.h;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends a {
    private LinearLayout aem;
    private TextView aen;
    private TextView aeo;
    private TextView aep;
    private TextView aeq;
    private int aer;
    private boolean aes = false;
    private boolean aet = false;
    private Runnable aeu = new Runnable() { // from class: com.kwad.components.core.page.d.a.c.1
        @Override // java.lang.Runnable
        public final void run() {
            if (!c.this.aes) {
                if (c.this.aer <= 0) {
                    c.this.aen.setText("任务已完成");
                    c.this.aeo.setVisibility(8);
                    c.this.aep.setVisibility(8);
                    c.this.aeq.setVisibility(8);
                    h hVar = (h) com.kwad.sdk.components.d.f(h.class);
                    if (hVar != null && !c.this.aet) {
                        hVar.notifyRewardVerify();
                    }
                } else {
                    c.this.uA();
                    by.runOnUiThreadDelay(this, 1000L);
                }
                c.i(c.this);
                return;
            }
            by.runOnUiThreadDelay(this, 500L);
        }
    };
    private final com.kwad.sdk.core.c.c Bi = new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.core.page.d.a.c.2
        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityResumed */
        public final void d(Activity activity) {
            super.d(activity);
            c.this.aes = false;
        }

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityPaused */
        public final void c(Activity activity) {
            super.c(activity);
            c.this.aes = true;
        }
    };

    static /* synthetic */ int i(c cVar) {
        int i = cVar.aer;
        cVar.aer = i - 1;
        return i;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.aem = (LinearLayout) findViewById(R.id.ksad_reward_land_page_open_tip);
        this.aen = (TextView) findViewById(R.id.ksad_reward_land_page_open_desc);
        this.aeo = (TextView) findViewById(R.id.ksad_reward_land_page_open_minute);
        this.aep = (TextView) findViewById(R.id.ksad_reward_land_page_open_colon);
        this.aeq = (TextView) findViewById(R.id.ksad_reward_land_page_open_second);
    }

    @Override // com.kwad.components.core.page.d.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(this.Bi);
        this.aer = com.kwad.sdk.core.config.e.Kj();
        uz();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.b(this.Bi);
        by.b(this.aeu);
    }

    private void uz() {
        this.aem.setVisibility(0);
        if (this.aec.mAdTemplate.mRewardVerifyCalled) {
            this.aen.setText("任务已完成");
            this.aeo.setVisibility(8);
            this.aep.setVisibility(8);
            this.aeq.setVisibility(8);
            return;
        }
        uA();
        by.runOnUiThreadDelay(this.aeu, 1000L);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void uA() {
        this.aeo.setText(uB());
        this.aeq.setText(uC());
    }

    private String uB() {
        int i = this.aer / 60;
        if (i >= 10) {
            return new StringBuilder().append(i).toString();
        }
        return "0" + i;
    }

    private String uC() {
        int i = this.aer % 60;
        if (i >= 10) {
            return new StringBuilder().append(i).toString();
        }
        return "0" + i;
    }
}
