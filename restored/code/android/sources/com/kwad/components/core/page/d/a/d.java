package com.kwad.components.core.page.d.a;

import android.view.View;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends a {
    private View aew;
    private TextView aex;
    private int aey;
    private Runnable aez = new Runnable() { // from class: com.kwad.components.core.page.d.a.d.1
        @Override // java.lang.Runnable
        public final void run() {
            if (!com.kwad.components.core.r.a.wy().wB()) {
                if (d.this.aey > 0) {
                    d.this.aex.setText(String.format("倒计时%d秒", Integer.valueOf(d.this.aey)));
                    d.c(d.this);
                    com.kwad.components.core.r.a.wy().bM(d.this.aey);
                    by.runOnUiThreadDelay(this, 1000L);
                    return;
                }
                d.this.aex.setText("已获得权益");
                by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.core.page.d.a.d.1.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        d.this.aew.setVisibility(8);
                    }
                }, 500L);
                com.kwad.components.core.r.a.wy().ba(true);
                return;
            }
            by.runOnUiThreadDelay(this, 500L);
        }
    };

    static /* synthetic */ int c(d dVar) {
        int i = dVar.aey;
        dVar.aey = i - 1;
        return i;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.aew = findViewById(R.id.ksad_web_reward_task_layout);
        this.aex = (TextView) findViewById(R.id.ksad_web_reward_task_text);
    }

    @Override // com.kwad.components.core.page.d.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.aey = com.kwad.sdk.core.response.helper.a.aS(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate));
        com.kwad.components.core.r.a.wy().bM(this.aey);
        uD();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        by.b(this.aez);
    }

    private void uD() {
        TextView textView;
        if (this.aew == null || (textView = this.aex) == null) {
            return;
        }
        textView.setText(String.format("倒计时%d秒", Integer.valueOf(this.aey)));
        this.aew.setVisibility(0);
        by.runOnUiThreadDelay(this.aez, 1000L);
    }
}
