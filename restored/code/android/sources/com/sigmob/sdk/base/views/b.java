package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Color;
import android.view.View;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.logger.SigmobLog;

/* JADX INFO: loaded from: classes3.dex */
public class b extends RelativeLayout {
    private static float d = 8.0f;
    private static final float e = 1.0f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3310a;
    private final ImageView b;
    private final TextView c;

    public b(Context context, int type) {
        super(context);
        this.f3310a = type;
        int iDipsToIntPixels = Dips.dipsToIntPixels(5.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(16.0f, context);
        ImageView imageView = new ImageView(context);
        this.b = imageView;
        imageView.setId(ClientMetadata.generateViewId());
        imageView.setScaleType(ImageView.ScaleType.FIT_START);
        imageView.setAdjustViewBounds(true);
        imageView.setMaxWidth(Dips.dipsToIntPixels(40.0f, context));
        imageView.setMinimumWidth(iDipsToIntPixels2);
        imageView.setBackgroundColor(Color.alpha(0));
        TextView textView = new TextView(context);
        this.c = textView;
        textView.setTextColor(Color.parseColor("#B9B9B9"));
        textView.setTextSize(1, 12.0f);
        textView.setGravity(17);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, iDipsToIntPixels2);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-2, iDipsToIntPixels2);
        if (type == 1) {
            layoutParams2.addRule(9);
            layoutParams2.addRule(12);
            int i = iDipsToIntPixels * 2;
            layoutParams2.setMargins(iDipsToIntPixels, 0, 0, i);
            layoutParams.addRule(11);
            layoutParams.addRule(12);
            layoutParams.setMargins(0, 0, iDipsToIntPixels, i);
        } else {
            layoutParams2.addRule(1, imageView.getId());
            layoutParams2.addRule(8, imageView.getId());
            layoutParams2.setMargins(0, 0, 0, 0);
            layoutParams.addRule(9);
            layoutParams.addRule(12);
            layoutParams.setMargins(iDipsToIntPixels, 0, 0, 0);
        }
        addView(imageView, layoutParams);
        addView(textView, layoutParams2);
    }

    public void a(Bitmap bitmap) {
        if (bitmap == null) {
            return;
        }
        this.b.setImageBitmap(bitmap);
    }

    public void a(String url) {
        com.sigmob.sdk.base.common.h.a().getBitmap(url, new ImageManager.BitmapLoadedListener() { // from class: com.sigmob.sdk.base.views.b.1
            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoadFailed() {
            }

            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoaded(Bitmap bitmap) {
                int iDipsToIntPixels = Dips.dipsToIntPixels(3.0f, b.this.getContext());
                if (bitmap == null) {
                    return;
                }
                if (b.this.f3310a != 1 && bitmap.getWidth() > bitmap.getHeight() * 1.5f) {
                    ((RelativeLayout.LayoutParams) b.this.b.getLayoutParams()).setMargins((-iDipsToIntPixels) * (bitmap.getWidth() / bitmap.getHeight()), 0, 0, 0);
                }
                b.this.b.setImageBitmap(bitmap);
            }
        });
    }

    public void b(String adText) {
        try {
            this.c.setText(adText);
        } catch (Throwable th) {
            SigmobLog.e("showAdText error", th);
        }
    }

    @Override // android.view.View
    public void setOnClickListener(View.OnClickListener listener) {
        ImageView imageView = this.b;
        if (imageView == null) {
            return;
        }
        imageView.setOnClickListener(listener);
    }
}
