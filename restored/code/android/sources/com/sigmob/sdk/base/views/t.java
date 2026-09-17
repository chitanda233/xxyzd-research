package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.view.View;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes3.dex */
public class t extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    Paint f3359a;
    private final float b;

    public t(Context context, float rating) {
        super(context);
        this.f3359a = new Paint();
        this.b = rating;
    }

    private Path a(float outR, float inR) {
        Path path = new Path();
        path.moveTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_UPDATE_TIMESTAMP_MODE) * outR, b(MediaPlayer.MEDIA_PLAYER_OPTION_UPDATE_TIMESTAMP_MODE) * outR);
        path.lineTo(a(108) * inR, b(108) * inR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE) * outR, b(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE) * outR);
        path.lineTo(a(180) * inR, b(180) * inR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIACODEC_DROP_NONREF) * outR, outR * b(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIACODEC_DROP_NONREF));
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_HW_DEC_DROP_NON_REF) * inR, inR * b(MediaPlayer.MEDIA_PLAYER_OPTION_HW_DEC_DROP_NON_REF));
        path.close();
        return path;
    }

    private Path b(float outR, float inR) {
        Path path = new Path();
        path.moveTo(a(0) * outR, b(0) * outR);
        path.lineTo(a(36) * inR, b(36) * inR);
        path.lineTo(a(72) * outR, b(72) * outR);
        path.lineTo(a(108) * inR, b(108) * inR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE) * outR, b(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE) * outR);
        path.lineTo(a(180) * inR, b(180) * inR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIACODEC_DROP_NONREF) * outR, b(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIACODEC_DROP_NONREF) * outR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_HW_DEC_DROP_NON_REF) * inR, b(MediaPlayer.MEDIA_PLAYER_OPTION_HW_DEC_DROP_NON_REF) * inR);
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_UPDATE_TIMESTAMP_MODE) * outR, outR * b(MediaPlayer.MEDIA_PLAYER_OPTION_UPDATE_TIMESTAMP_MODE));
        path.lineTo(a(MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_FLV_ABR) * inR, inR * b(MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_FLV_ABR));
        path.close();
        return path;
    }

    float a(int num) {
        return (float) Math.cos((((double) num) * 3.141592653589793d) / 180.0d);
    }

    float b(int num) {
        return (float) Math.sin((((double) num) * 3.141592653589793d) / 180.0d);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        Path pathB;
        super.onDraw(canvas);
        int height = getHeight();
        int i = (int) this.b;
        float f = height;
        float f2 = f / 3.0f;
        float fB = (b(18) * f2) / b(126);
        boolean z = true;
        this.f3359a.setAntiAlias(true);
        this.f3359a.setColor(Color.parseColor("#FFA500"));
        for (int i2 = i; i2 > 0; i2--) {
            if (z) {
                canvas.translate(f2 + 2.0f, f / 2.0f);
                z = false;
            } else {
                canvas.rotate(18.0f);
                canvas.translate(2.2f * f2, 0.0f);
            }
            canvas.rotate(-18.0f);
            Path pathB2 = b(f2, fB);
            this.f3359a.setStyle(Paint.Style.STROKE);
            canvas.drawPath(pathB2, this.f3359a);
            this.f3359a.setStyle(Paint.Style.FILL);
            canvas.drawPath(pathB2, this.f3359a);
        }
        float f3 = this.b;
        float f4 = i;
        if (f3 > f4) {
            float f5 = (f3 - f4) + 0.25f;
            if (f5 >= 1.0f) {
                canvas.rotate(18.0f);
                canvas.translate(f2 * 2.2f, 0.0f);
                canvas.rotate(-18.0f);
                pathB = b(f2, fB);
                this.f3359a.setStyle(Paint.Style.STROKE);
                this.f3359a.setColor(Color.parseColor("#FFA500"));
                canvas.drawPath(pathB, this.f3359a);
            } else {
                canvas.rotate(18.0f);
                if (f5 >= 0.5f) {
                    canvas.translate(f2 * 2.2f, 0.0f);
                    canvas.rotate(-18.0f);
                    Path pathB3 = b(f2, fB);
                    this.f3359a.setColor(Color.parseColor("#FFA500"));
                    this.f3359a.setStyle(Paint.Style.STROKE);
                    canvas.drawPath(pathB3, this.f3359a);
                    pathB = a(f2, fB);
                    this.f3359a.setColor(Color.parseColor("#FFA500"));
                } else {
                    canvas.translate(f2 * 2.2f, 0.0f);
                    canvas.rotate(-18.0f);
                    pathB = b(f2, fB);
                    this.f3359a.setStyle(Paint.Style.STROKE);
                    this.f3359a.setColor(Color.parseColor("#FFA500"));
                }
                canvas.drawPath(pathB, this.f3359a);
            }
            this.f3359a.setStyle(Paint.Style.FILL);
            canvas.drawPath(pathB, this.f3359a);
        }
        for (int i3 = (int) (5.0f - this.b); i3 > 0; i3--) {
            canvas.rotate(18.0f);
            canvas.translate(f2 * 2.2f, 0.0f);
            canvas.rotate(-18.0f);
            Path pathB4 = b(f2, fB);
            this.f3359a.setStyle(Paint.Style.STROKE);
            this.f3359a.setColor(Color.parseColor("#FFA500"));
            canvas.drawPath(pathB4, this.f3359a);
        }
    }
}
