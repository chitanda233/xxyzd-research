package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.drawable.GradientDrawable;
import android.net.Uri;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public class ar extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ImageView f3303a;
    private final int b;

    public ar(final Context context) {
        super(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(22.0f, context);
        this.b = iDipsToIntPixels;
        b(Dips.dipsToIntPixels(15.0f, context));
        ViewGroup.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
        GradientDrawable gradientDrawable = new GradientDrawable();
        gradientDrawable.setColor(-16777216);
        gradientDrawable.setStroke(1, -1);
        gradientDrawable.setCornerRadius(iDipsToIntPixels / 2);
        gradientDrawable.setAlpha(102);
        setBackground(gradientDrawable);
        setLayoutParams(layoutParams);
    }

    private void b(int width) {
        this.f3303a = new ImageView(getContext());
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(width, width);
        layoutParams.addRule(13);
        this.f3303a.setImageBitmap(s.CLOSE_NEW.a());
        this.f3303a.setScaleType(ImageView.ScaleType.CENTER_CROP);
        this.f3303a.setImageAlpha(204);
        addView(this.f3303a, layoutParams);
    }

    private void b(final String imageUrl) {
        com.sigmob.sdk.base.common.h.a().getBitmap(imageUrl, new ImageManager.BitmapLoadedListener() { // from class: com.sigmob.sdk.base.views.ar.1
            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoadFailed() {
            }

            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoaded(Bitmap bitmap) {
                if (bitmap == null) {
                    SigmobLog.d(String.format("%s returned null bitmap", imageUrl));
                } else {
                    ar.this.f3303a.setImageBitmap(bitmap);
                }
            }
        });
    }

    public void a(final int resId) {
        this.f3303a.setImageResource(resId);
    }

    public void a(final Bitmap bitmap) {
        this.f3303a.setImageBitmap(bitmap);
    }

    public void a(BaseAdUnit adUnit) {
        ImageView imageView;
        s sVar;
        if (adUnit == null || adUnit.getEndcardCloseImage() != 1) {
            GradientDrawable gradientDrawable = new GradientDrawable();
            gradientDrawable.setColor(0);
            setBackground(gradientDrawable);
            int i = this.b;
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(i, i);
            layoutParams.addRule(13);
            this.f3303a.setLayoutParams(layoutParams);
            imageView = this.f3303a;
            sVar = s.CLOSE_OLD;
        } else {
            imageView = this.f3303a;
            sVar = s.CLOSE_NEW;
        }
        imageView.setImageBitmap(sVar.a());
    }

    public void a(final String imageUrl) {
        String lowerCase = imageUrl.toLowerCase();
        if (lowerCase.startsWith("http://") || lowerCase.startsWith("https://")) {
            b(imageUrl);
        } else if (lowerCase.startsWith("file://")) {
            try {
                this.f3303a.setImageURI(Uri.fromFile(new File(imageUrl)));
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
            }
        }
    }
}
