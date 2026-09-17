package com.kwad.components.core.innerEc.live.comment;

import android.content.Context;
import android.text.SpannableStringBuilder;
import android.text.TextUtils;
import com.kwad.components.core.innerEc.live.base.QLiveMessage;
import com.kwad.components.core.innerEc.live.i.f;
import com.kwad.components.core.innerEc.live.widget.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.c.b;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static CharSequence a(Context context, QLiveMessage qLiveMessage) {
        m mVar = new m(context, new SpannableStringBuilder());
        if (!TextUtils.isEmpty(qLiveMessage.user.userName)) {
            m.a aVarA = f.a(qLiveMessage.user.userName + "：", context);
            aVarA.ba(R.color.ksad_color_FFDA73);
            mVar.a(aVarA);
        }
        m.a aVarA2 = f.a(qLiveMessage.content, context);
        aVarA2.ba(TextUtils.isEmpty(qLiveMessage.user.userName) ? R.color.ksad_color_FFDA73 : R.color.ksad_color_FEFEFE);
        mVar.a(aVarA2);
        return com.kwad.components.core.innerEc.f.a(b.Mh().getApplication(), mVar.tu(), com.kwad.sdk.c.a.a.a(context, 10.0f));
    }
}
