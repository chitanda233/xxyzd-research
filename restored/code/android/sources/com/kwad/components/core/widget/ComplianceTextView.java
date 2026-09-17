package com.kwad.components.core.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Color;
import android.graphics.Paint;
import android.text.SpannableStringBuilder;
import android.text.TextPaint;
import android.text.TextUtils;
import android.text.method.LinkMovementMethod;
import android.text.style.ClickableSpan;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import androidx.core.content.ContextCompat;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public class ComplianceTextView extends TextView {
    private String avA;
    private String avB;
    private String avC;
    private String avD;
    private int avE;
    private String avx;
    private String avy;
    private String avz;
    private AdTemplate mAdTemplate;
    private int textColor;

    public ComplianceTextView(Context context) {
        this(context, null);
    }

    public ComplianceTextView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public ComplianceTextView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.avx = "...\n";
        this.avE = MediaPlayer.MEDIA_PLAYER_OPTION_REUSE_SOCKET;
        init(context, attributeSet);
    }

    private void init(Context context, AttributeSet attributeSet) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_ComplianceTextView);
        this.avE = typedArrayObtainStyledAttributes.getDimensionPixelOffset(R.styleable.ksad_ComplianceTextView_ksad_width_in_landscape, MediaPlayer.MEDIA_PLAYER_OPTION_REUSE_SOCKET);
        int color = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_ComplianceTextView_ksad_privacy_color, Color.parseColor("#99FFFFFF"));
        this.textColor = color;
        setTextColor(color);
        if (as.isOrientationPortrait()) {
            setBackgroundColor(0);
        } else {
            setBackground(ContextCompat.getDrawable(context, R.drawable.ksad_compliance_view_bg));
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public void setAdTemplate(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.avy = "功能";
        this.avz = "权限";
        this.avA = "隐私";
        this.avB = adInfoEM.downloadSafeInfo.appPermissionInfoUrl;
        this.avD = adInfoEM.downloadSafeInfo.appPrivacyUrl;
        this.avC = adInfoEM.downloadSafeInfo.introductionInfoUrl;
        if (this.avE > 0) {
            ViewGroup.LayoutParams layoutParams = getLayoutParams();
            getContext();
            if (!as.VV()) {
                layoutParams.width = com.kwad.sdk.c.a.a.a(getContext(), this.avE);
            } else {
                layoutParams.width = -1;
            }
            setLayoutParams(layoutParams);
        }
        post(new bi() { // from class: com.kwad.components.core.widget.ComplianceTextView.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ComplianceTextView.this.a(adInfoEM.downloadSafeInfo.appName, TextUtils.isEmpty(adInfoEM.downloadSafeInfo.corporationName) ? "" : adInfoEM.downloadSafeInfo.corporationName, TextUtils.isEmpty(adInfoEM.downloadSafeInfo.recordNumber) ? "" : adInfoEM.downloadSafeInfo.recordNumber, adInfoEM.downloadSafeInfo.appVersion, ComplianceTextView.this.avy, ComplianceTextView.this.avz, ComplianceTextView.this.avA);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, String str3, String str4, String str5, String str6, String str7) {
        int width;
        boolean z;
        if (TextUtils.isEmpty(str)) {
            setVisibility(8);
            return;
        }
        getContext();
        if (!as.VV()) {
            width = (this.avE - getPaddingLeft()) - getPaddingRight();
            z = true;
        } else {
            width = (getWidth() - getPaddingLeft()) - getPaddingRight();
            z = false;
        }
        if (width < 0) {
            return;
        }
        if (!z && !TextUtils.isEmpty(str2)) {
            Paint paint = new Paint();
            paint.setTextSize(getTextSize());
            float fMeasureText = width - paint.measureText(str);
            StringBuilder sb = new StringBuilder();
            if (paint.measureText(sb.append(" ").append(str2).toString()) > fMeasureText && fMeasureText > 0.0f) {
                while (str2.length() > 1) {
                    str2 = str2.substring(0, str2.length() - 1);
                    sb.setLength(0);
                    if (paint.measureText(sb.append(" ").append(str2).append(this.avx).toString()) <= fMeasureText) {
                        break;
                    }
                }
            } else {
                this.avx = "";
            }
        } else {
            this.avx = "";
        }
        b(str, str2 + this.avx, str3, str4, str5, str6, str7);
        requestLayout();
    }

    private void b(String str, String str2, String str3, String str4, String str5, String str6, String str7) {
        SpannableStringBuilder spannableStringBuilder = new SpannableStringBuilder();
        if (!TextUtils.isEmpty(str)) {
            spannableStringBuilder.append((CharSequence) str);
        }
        if (!TextUtils.isEmpty(str2)) {
            spannableStringBuilder.append((CharSequence) " ").append((CharSequence) str2);
        }
        if (!TextUtils.isEmpty(str3)) {
            spannableStringBuilder.append((CharSequence) " ").append((CharSequence) str3);
        }
        if (!TextUtils.isEmpty(str4)) {
            spannableStringBuilder.append((CharSequence) " | 版本 ").append((CharSequence) str4);
        }
        if (!TextUtils.isEmpty(this.avC)) {
            int length = spannableStringBuilder.length();
            spannableStringBuilder.append((CharSequence) " | ").append((CharSequence) str5);
            spannableStringBuilder.setSpan(new ClickableSpan() { // from class: com.kwad.components.core.widget.ComplianceTextView.2
                @Override // android.text.style.ClickableSpan
                public final void onClick(View view) {
                    AdWebViewActivityProxy.launch(ComplianceTextView.this.getContext(), new AdWebViewActivityProxy.a.C0449a().aW("功能介绍").aX(ComplianceTextView.this.avC).aQ(true).aU(ComplianceTextView.this.mAdTemplate).um());
                }

                @Override // android.text.style.ClickableSpan, android.text.style.CharacterStyle
                public final void updateDrawState(TextPaint textPaint) {
                    super.updateDrawState(textPaint);
                    textPaint.setColor(ComplianceTextView.this.textColor);
                    textPaint.setUnderlineText(false);
                }
            }, length, spannableStringBuilder.length(), 33);
        }
        if (!TextUtils.isEmpty(this.avB)) {
            int length2 = spannableStringBuilder.length();
            spannableStringBuilder.append((CharSequence) " | ").append((CharSequence) str6);
            spannableStringBuilder.setSpan(new ClickableSpan() { // from class: com.kwad.components.core.widget.ComplianceTextView.3
                @Override // android.text.style.ClickableSpan
                public final void onClick(View view) {
                    AdWebViewActivityProxy.launch(ComplianceTextView.this.getContext(), new AdWebViewActivityProxy.a.C0449a().aW("权限信息").aX(ComplianceTextView.this.avB).aQ(true).aU(ComplianceTextView.this.mAdTemplate).um());
                }

                @Override // android.text.style.ClickableSpan, android.text.style.CharacterStyle
                public final void updateDrawState(TextPaint textPaint) {
                    super.updateDrawState(textPaint);
                    textPaint.setColor(ComplianceTextView.this.textColor);
                    textPaint.setUnderlineText(false);
                }
            }, length2, spannableStringBuilder.length(), 33);
        }
        if (!TextUtils.isEmpty(this.avD)) {
            int length3 = spannableStringBuilder.length();
            spannableStringBuilder.append((CharSequence) " | ").append((CharSequence) str7);
            spannableStringBuilder.setSpan(new ClickableSpan() { // from class: com.kwad.components.core.widget.ComplianceTextView.4
                @Override // android.text.style.ClickableSpan
                public final void onClick(View view) {
                    AdWebViewActivityProxy.launch(ComplianceTextView.this.getContext(), new AdWebViewActivityProxy.a.C0449a().aW("隐私政策").aX(ComplianceTextView.this.avD).aQ(true).aU(ComplianceTextView.this.mAdTemplate).um());
                }

                @Override // android.text.style.ClickableSpan, android.text.style.CharacterStyle
                public final void updateDrawState(TextPaint textPaint) {
                    super.updateDrawState(textPaint);
                    textPaint.setColor(ComplianceTextView.this.textColor);
                    textPaint.setUnderlineText(false);
                }
            }, length3, spannableStringBuilder.length(), 33);
        }
        spannableStringBuilder.append((CharSequence) " ");
        setMovementMethod(LinkMovementMethod.getInstance());
        setHighlightColor(ContextCompat.getColor(getContext(), R.color.ksad_translucent));
        setText(spannableStringBuilder);
    }
}
