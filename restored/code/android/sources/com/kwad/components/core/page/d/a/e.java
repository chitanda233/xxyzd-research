package com.kwad.components.core.page.d.a;

import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends a {
    private LinearLayout adi;
    private TextView adj;
    private ImageView adk;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.core.page.d.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        uE();
    }

    private void uE() {
        this.adi = (LinearLayout) findViewById(R.id.ksad_web_tip_bar);
        if (!TextUtils.isEmpty(this.aec.mPageTitle)) {
            this.adi.setVisibility(8);
            return;
        }
        this.adj = (TextView) findViewById(R.id.ksad_web_tip_bar_textview);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_web_tip_close_btn);
        this.adk = imageView;
        imageView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.page.d.a.e.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                e.this.adi.setVisibility(8);
            }
        });
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate);
        boolean zBF = com.kwad.sdk.core.response.helper.a.bF(adInfoEM);
        String strBB = com.kwad.sdk.core.response.helper.a.bB(adInfoEM);
        if (zBF) {
            this.adi.setVisibility(0);
            this.adj.setText(strBB);
            this.adj.setSelected(true);
        } else {
            this.adi.setVisibility(8);
        }
        this.aec.a(uF());
    }

    private KsAdWebView.c uF() {
        return new KsAdWebView.c() { // from class: com.kwad.components.core.page.d.a.e.2
            @Override // com.kwad.sdk.core.webview.KsAdWebView.c
            public final void uG() {
                if (e.this.aec.uh() && e.this.adi.getVisibility() == 0) {
                    e.this.adi.setVisibility(8);
                }
            }
        };
    }
}
