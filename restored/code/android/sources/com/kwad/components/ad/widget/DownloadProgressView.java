package com.kwad.components.ad.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.drawable.Drawable;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.TextView;
import com.kwad.components.core.page.widget.TextProgressBar;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class DownloadProgressView extends FrameLayout {
    protected TextView NS;
    private int NT;
    private int NU;
    private int NV;
    private int NW;
    protected Drawable NX;
    protected Drawable NY;
    private String NZ;
    private final KsAppDownloadListener ei;
    protected TextProgressBar gd;
    protected AdInfo mAdInfo;
    protected AdTemplate mAdTemplate;

    public DownloadProgressView(Context context) {
        this(context, null);
    }

    public DownloadProgressView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public DownloadProgressView(Context context, AttributeSet attributeSet, int i) {
        super(m.wrapContextIfNeed(context), attributeSet, i);
        this.ei = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.widget.DownloadProgressView.2
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                DownloadProgressView.this.NS.setText(com.kwad.sdk.core.response.helper.a.aK(DownloadProgressView.this.mAdInfo));
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i2) {
                DownloadProgressView.this.NS.setVisibility(8);
                DownloadProgressView.this.gd.setVisibility(0);
                DownloadProgressView.this.gd.e(com.kwad.sdk.core.response.helper.a.x(i2, DownloadProgressView.this.NZ), i2);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                DownloadProgressView.this.NS.setVisibility(8);
                DownloadProgressView.this.gd.setVisibility(0);
                DownloadProgressView.this.gd.e(com.kwad.sdk.core.response.helper.a.cF(DownloadProgressView.this.mAdTemplate), DownloadProgressView.this.gd.getMax());
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                DownloadProgressView.this.NS.setText(com.kwad.sdk.core.response.helper.a.aK(DownloadProgressView.this.mAdInfo));
                DownloadProgressView.this.NS.setVisibility(0);
                DownloadProgressView.this.gd.setVisibility(8);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                DownloadProgressView.this.NS.setVisibility(8);
                DownloadProgressView.this.gd.setVisibility(0);
                DownloadProgressView.this.gd.e(com.kwad.sdk.core.response.helper.a.af(DownloadProgressView.this.mAdInfo), DownloadProgressView.this.gd.getMax());
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i2) {
                DownloadProgressView.this.NS.setVisibility(8);
                DownloadProgressView.this.gd.setVisibility(0);
                DownloadProgressView.this.gd.e(com.kwad.sdk.core.response.helper.a.NH(), i2);
            }
        };
        initAttrs(context, attributeSet);
        initView();
    }

    private void initAttrs(Context context, AttributeSet attributeSet) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_DownloadProgressView);
        this.NT = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_DownloadProgressView_ksad_downloadTextColor, -117146);
        this.NU = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_DownloadProgressView_ksad_downloadLeftTextColor, -1);
        this.NV = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_DownloadProgressView_ksad_downloadRightTextColor, -117146);
        this.NW = typedArrayObtainStyledAttributes.getDimensionPixelSize(R.styleable.ksad_DownloadProgressView_ksad_downloadTextSize, com.kwad.sdk.c.a.a.a(getContext(), 11.0f));
        Drawable drawable = typedArrayObtainStyledAttributes.getDrawable(R.styleable.ksad_DownloadProgressView_ksad_progressDrawable);
        this.NX = drawable;
        if (drawable == null) {
            or();
        }
        Drawable drawable2 = typedArrayObtainStyledAttributes.getDrawable(R.styleable.ksad_DownloadProgressView_ksad_backgroundDrawable);
        this.NY = drawable2;
        if (drawable2 == null) {
            os();
        }
        String string = typedArrayObtainStyledAttributes.getString(R.styleable.ksad_DownloadProgressView_ksad_downloadingFormat);
        this.NZ = string;
        if (string == null) {
            this.NZ = "下载中  %s%%";
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    protected void oq() {
        m.inflate(getContext(), R.layout.ksad_download_progress_layout, this);
    }

    protected void or() {
        this.NX = getResources().getDrawable(R.drawable.ksad_feed_download_progress);
    }

    protected void os() {
        this.NY = getResources().getDrawable(R.drawable.ksad_feed_app_download_before_bg);
    }

    private void initView() {
        oq();
        TextProgressBar textProgressBar = (TextProgressBar) findViewById(R.id.ksad_progress_bar);
        this.gd = textProgressBar;
        textProgressBar.setTextDimen(this.NW);
        this.gd.setTextColor(this.NU, this.NV);
        this.gd.setProgressDrawable(this.NX);
        TextView textView = (TextView) findViewById(R.id.ksad_normal_text);
        this.NS = textView;
        textView.setTextColor(this.NT);
        this.NS.setTextSize(0, this.NW);
        this.NS.setVisibility(0);
        this.NS.setBackground(this.NY);
        findViewById(R.id.ksad_foreground_cover).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.widget.DownloadProgressView.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                DownloadProgressView.this.performClick();
            }
        });
    }

    public final void aw(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        this.NS.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        this.gd.setVisibility(8);
        this.NS.setVisibility(0);
    }

    public KsAppDownloadListener getAppDownloadListener() {
        return this.ei;
    }
}
