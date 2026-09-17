package com.kwad.sdk.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.drawable.Drawable;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import com.kwad.sdk.R;
import java.math.BigDecimal;

/* JADX INFO: loaded from: classes3.dex */
public class KSRatingBar extends LinearLayout {
    private boolean bsZ;
    private boolean bta;
    private int btb;
    private int btc;
    private a btd;
    private float bte;
    private float btf;
    private float btg;
    private Drawable bth;
    private Drawable bti;
    private Drawable btj;
    private boolean btk;
    private int y;

    public interface a {
    }

    static /* synthetic */ int e(KSRatingBar kSRatingBar) {
        int i = kSRatingBar.y;
        kSRatingBar.y = i + 1;
        return i;
    }

    public void setStarHalfDrawable(Drawable drawable) {
        this.btj = drawable;
    }

    public void setOnRatingChangeListener(a aVar) {
        this.btd = aVar;
    }

    public void setmClickable(boolean z) {
        this.bsZ = z;
    }

    public void setStarFillDrawable(Drawable drawable) {
        this.bti = drawable;
    }

    public void setStarEmptyDrawable(Drawable drawable) {
        this.bth = drawable;
    }

    public void setStarImageWidth(float f) {
        this.bte = f;
    }

    public void setStarImageHeight(float f) {
        this.btf = f;
    }

    public void setTotalStarCount(int i) {
        this.btb = i;
    }

    public void setImagePadding(float f) {
        this.btg = f;
    }

    public KSRatingBar(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.y = 1;
        this.btk = false;
        setOrientation(0);
        setDividerDrawable(getResources().getDrawable(R.drawable.ksad_reward_apk_stars_divider));
        setShowDividers(2);
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KSRatingBar);
        this.btj = typedArrayObtainStyledAttributes.getDrawable(R.styleable.ksad_KSRatingBar_ksad_starHalf);
        this.bth = typedArrayObtainStyledAttributes.getDrawable(R.styleable.ksad_KSRatingBar_ksad_starEmpty);
        this.bti = typedArrayObtainStyledAttributes.getDrawable(R.styleable.ksad_KSRatingBar_ksad_starFill);
        this.bte = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSRatingBar_ksad_starImageWidth, 60.0f);
        this.btf = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSRatingBar_ksad_starImageHeight, 120.0f);
        this.btg = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSRatingBar_ksad_starImagePadding, 15.0f);
        this.btb = typedArrayObtainStyledAttributes.getInteger(R.styleable.ksad_KSRatingBar_ksad_totalStarCount, 5);
        this.btc = typedArrayObtainStyledAttributes.getInteger(R.styleable.ksad_KSRatingBar_ksad_starCount, 5);
        this.bsZ = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KSRatingBar_ksad_clickable, true);
        this.bta = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KSRatingBar_ksad_halfstart, false);
        for (int i = 0; i < this.btb; i++) {
            ImageView imageViewD = D(context, this.btk);
            imageViewD.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.sdk.widget.KSRatingBar.1
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    if (KSRatingBar.this.bsZ) {
                        if (KSRatingBar.this.bta) {
                            if (KSRatingBar.this.y % 2 == 0) {
                                KSRatingBar kSRatingBar = KSRatingBar.this;
                                kSRatingBar.setStar(kSRatingBar.indexOfChild(view) + 1.0f);
                            } else {
                                KSRatingBar kSRatingBar2 = KSRatingBar.this;
                                kSRatingBar2.setStar(kSRatingBar2.indexOfChild(view) + 0.5f);
                            }
                            if (KSRatingBar.this.btd != null) {
                                if (KSRatingBar.this.y % 2 == 0) {
                                    a unused = KSRatingBar.this.btd;
                                    KSRatingBar.this.indexOfChild(view);
                                    KSRatingBar.e(KSRatingBar.this);
                                    return;
                                } else {
                                    a unused2 = KSRatingBar.this.btd;
                                    KSRatingBar.this.indexOfChild(view);
                                    KSRatingBar.e(KSRatingBar.this);
                                    return;
                                }
                            }
                            return;
                        }
                        KSRatingBar kSRatingBar3 = KSRatingBar.this;
                        kSRatingBar3.setStar(kSRatingBar3.indexOfChild(view) + 1.0f);
                        if (KSRatingBar.this.btd != null) {
                            a unused3 = KSRatingBar.this.btd;
                            KSRatingBar.this.indexOfChild(view);
                        }
                    }
                }
            });
            addView(imageViewD);
        }
        setStar(this.btc);
    }

    private ImageView D(Context context, boolean z) {
        ImageView imageView = new ImageView(context);
        imageView.setLayoutParams(new ViewGroup.LayoutParams(Math.round(this.bte), Math.round(this.btf)));
        imageView.setPadding(0, 0, Math.round(this.btg), 0);
        if (z) {
            imageView.setImageDrawable(this.bth);
        } else {
            imageView.setImageDrawable(this.bti);
        }
        return imageView;
    }

    public void setStar(float f) {
        int i = (int) f;
        float fFloatValue = new BigDecimal(Float.toString(f)).subtract(new BigDecimal(Integer.toString(i))).floatValue();
        int i2 = this.btb;
        float f2 = i > i2 ? i2 : i;
        if (f2 < 0.0f) {
            f2 = 0.0f;
        }
        for (int i3 = 0; i3 < f2; i3++) {
            ((ImageView) getChildAt(i3)).setImageDrawable(this.bti);
        }
        if (fFloatValue > 0.0f) {
            ((ImageView) getChildAt(i)).setImageDrawable(this.btj);
            int i4 = this.btb;
            while (true) {
                i4--;
                if (i4 < 1.0f + f2) {
                    return;
                } else {
                    ((ImageView) getChildAt(i4)).setImageDrawable(this.bth);
                }
            }
        } else {
            int i5 = this.btb;
            while (true) {
                i5--;
                if (i5 < f2) {
                    return;
                } else {
                    ((ImageView) getChildAt(i5)).setImageDrawable(this.bth);
                }
            }
        }
    }
}
