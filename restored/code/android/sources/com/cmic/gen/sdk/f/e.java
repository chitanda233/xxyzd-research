package com.cmic.gen.sdk.f;

import android.graphics.Paint;
import android.graphics.Rect;
import android.os.Build;
import android.text.SpannableString;
import android.text.style.LineHeightSpan;
import android.widget.TextView;

/* JADX INFO: compiled from: NoPaddingTextviewUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class e {
    public static void a(final TextView textView, CharSequence charSequence) {
        if (textView == null || charSequence == null) {
            return;
        }
        textView.setPadding(textView.getPaddingLeft(), 0, textView.getPaddingRight(), 0);
        SpannableString spannableString = new SpannableString(charSequence);
        spannableString.setSpan(new LineHeightSpan() { // from class: com.cmic.gen.sdk.f.e.1
            @Override // android.text.style.LineHeightSpan
            public void chooseHeight(CharSequence charSequence2, int i, int i2, int i3, int i4, Paint.FontMetricsInt fontMetricsInt) {
                Rect rect = new Rect();
                if (Build.VERSION.SDK_INT >= 29) {
                    textView.getPaint().getTextBounds(charSequence2, 0, charSequence2.length(), rect);
                } else {
                    textView.getPaint().getTextBounds(charSequence2.toString(), 0, charSequence2.length(), rect);
                }
                if (rect.bottom - rect.top < textView.getTextSize()) {
                    float textSize = (textView.getTextSize() - (rect.bottom - rect.top)) / 2.0f;
                    fontMetricsInt.top = (int) (rect.top - textSize);
                    fontMetricsInt.bottom = (int) (rect.bottom + textSize);
                } else {
                    fontMetricsInt.top = rect.top;
                    fontMetricsInt.bottom = rect.bottom;
                }
                fontMetricsInt.ascent = fontMetricsInt.top;
                fontMetricsInt.descent = fontMetricsInt.bottom;
            }
        }, 0, charSequence.length(), 33);
        textView.setText(spannableString);
    }
}
