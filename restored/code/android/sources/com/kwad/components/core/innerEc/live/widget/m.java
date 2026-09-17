package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.graphics.Typeface;
import android.text.SpannableStringBuilder;
import android.text.TextPaint;
import android.text.TextUtils;
import android.text.style.AbsoluteSizeSpan;
import android.text.style.ForegroundColorSpan;
import android.view.View;
import androidx.core.content.ContextCompat;

/* JADX INFO: loaded from: classes3.dex */
public final class m {
    private final SpannableStringBuilder aan;
    private boolean aao = true;
    private Context mContext;

    public m(Context context, SpannableStringBuilder spannableStringBuilder) {
        this.aan = spannableStringBuilder;
        this.mContext = context;
    }

    private m b(CharSequence charSequence) {
        if (TextUtils.isEmpty(charSequence)) {
            return this;
        }
        this.aan.append(charSequence);
        return this;
    }

    public final m a(final a aVar) {
        if (aVar != null && !TextUtils.isEmpty(aVar.aar)) {
            b(aVar.aar);
            int length = length();
            int length2 = length - aVar.length();
            if (aVar.aas != 0) {
                a(new ForegroundColorSpan(aVar.aas) { // from class: com.kwad.components.core.innerEc.live.widget.m.1
                    @Override // android.text.style.ForegroundColorSpan, android.text.style.CharacterStyle
                    public final void updateDrawState(TextPaint textPaint) {
                        super.updateDrawState(textPaint);
                        if (aVar.aau) {
                            textPaint.setFakeBoldText(true);
                        }
                        if (aVar.aav != null) {
                            textPaint.setTypeface(aVar.aav);
                        }
                    }
                }, length2, length);
            }
            if (aVar.Fp != 0) {
                o oVar = new o(3.0f, 0.0f, 3.0f, aVar.Fp);
                oVar.aO(true);
                a(oVar, length2, length);
            }
            if (aVar.aat > 0) {
                a(new AbsoluteSizeSpan(aVar.aat), length2, length);
            }
            if (aVar.aaw != null) {
                a(new n(aVar.aaw), length2, length);
            }
        }
        return this;
    }

    private m a(Object obj, int i, int i2) {
        this.aan.setSpan(obj, i, i2, 33);
        return this;
    }

    private int length() {
        return this.aan.length();
    }

    public final SpannableStringBuilder tu() {
        return this.aan;
    }

    public static class a {
        private int Fp;
        private CharSequence aar;
        private int aas;
        private int aat;
        private boolean aau;
        private Typeface aav;
        private View.OnClickListener aaw;
        private Context mContext;

        public a(CharSequence charSequence, Context context) {
            this.aar = charSequence;
            this.mContext = context;
        }

        public final a ba(int i) {
            bb(ContextCompat.getColor(this.mContext, i));
            return this;
        }

        private a bb(int i) {
            this.aas = i;
            return this;
        }

        public final a bc(int i) {
            if (i != 0) {
                bd(ContextCompat.getColor(this.mContext, i));
            }
            return this;
        }

        private a bd(int i) {
            this.Fp = i;
            return this;
        }

        public final int length() {
            return this.aar.length();
        }
    }
}
