package com.bytedance.sdk.openadsdk.core.activity.base;

import android.os.Bundle;
import android.view.View;
import com.byazt.dh.ve;
import com.byazt.ff.TTScrollView;
import com.byazt.nr.m;
import com.byazt.un.uj;
import com.byazt.vfu.a;

/* JADX INFO: loaded from: classes2.dex */
public class TTVideoScrollWebPageActivity extends TTVideoWebPageActivity {
    private TTScrollView bx;

    @Override // com.byazt.cty.BaseLandingPageActivity, com.byazt.cty.BaseThemeActivity, android.app.Activity
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        TTScrollView tTScrollView = (TTScrollView) findViewById(2114387873);
        this.bx = tTScrollView;
        tTScrollView.setListener(new TTScrollView.c() { // from class: com.bytedance.sdk.openadsdk.core.activity.base.TTVideoScrollWebPageActivity.1
            @Override // com.byazt.ff.TTScrollView.c
            public void c(boolean z) {
                try {
                    if (TTVideoScrollWebPageActivity.this.pf != null && (TTVideoScrollWebPageActivity.this.pf instanceof uj)) {
                        if (z && !TTVideoScrollWebPageActivity.this.pf.gt()) {
                            ((uj) TTVideoScrollWebPageActivity.this.pf).a(false);
                        } else {
                            TTVideoScrollWebPageActivity.this.pf.a();
                        }
                    }
                } catch (Throwable th) {
                    m.ve("TTVideoScrollWebPageActivity", "onCreate isShow error", th);
                }
            }
        });
        if (this.pf != null) {
            this.pf.uj(false);
        }
        if (this.nb != null) {
            this.nb.setVideoAdInteractionListener(new ve.InterfaceC0102ve() { // from class: com.bytedance.sdk.openadsdk.core.activity.base.TTVideoScrollWebPageActivity.2
                @Override // com.byazt.dh.ve.InterfaceC0102ve
                public void onProgressUpdate(long j, long j2) {
                }

                @Override // com.byazt.dh.ve.InterfaceC0102ve
                public void onVideoAdContinuePlay() {
                }

                @Override // com.byazt.dh.ve.InterfaceC0102ve
                public void onVideoAdPaused() {
                }

                @Override // com.byazt.dh.ve.InterfaceC0102ve
                public void onVideoComplete() {
                }

                @Override // com.byazt.dh.ve.InterfaceC0102ve
                public void onVideoAdStartPlay() {
                    if (TTVideoScrollWebPageActivity.this.bx == null || TTVideoScrollWebPageActivity.this.bx.c() || TTVideoScrollWebPageActivity.this.pf == null) {
                        return;
                    }
                    TTVideoScrollWebPageActivity.this.pf.sp();
                }
            });
        }
    }

    @Override // android.app.Activity
    public void setContentView(View view) {
        super.setContentView(a.pf(this));
    }
}
